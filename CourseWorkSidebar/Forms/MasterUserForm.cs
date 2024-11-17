using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.Forms
{
    public partial class MasterUserForm : Form
    {
        private readonly VehiclesRepository _vehiclesRepository;
        private readonly FaultRepository _faultRepository;
        private Master _currentMaster;

        public MasterUserForm(Master master)
        {
            InitializeComponent();
            _currentMaster = master;
            _vehiclesRepository = new VehiclesRepository();
            _faultRepository = new FaultRepository();

            LoadAssignedVehicles();
            LoadFaults();
            btnMarkAsResolved.Click += BtnResolveFault_Click;
        }

        private void LoadAssignedVehicles()
        {
            // Load the vehicles assigned to the current master
            var vehicles = _vehiclesRepository.GetAllVehicles().Where(v => v.AssignedMaster == _currentMaster.MasterID).ToList();
            dataGridViewAssignedVehicles.DataSource = vehicles;
        }

        private void LoadFaults()
        {
            // Load all reported faults
            var faults = _faultRepository.GetAllFaults();
            dataGridViewReportedFaults.DataSource = faults;
        }

        private void BtnResolveFault_Click(object sender, EventArgs e)
        {
            var selectedFault = dataGridViewReportedFaults.CurrentRow?.DataBoundItem as Fault;
            if (selectedFault == null)
            {
                MessageBox.Show("Будь ласка, виберіть несправність для вирішення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedVehicle = _vehiclesRepository.GetVehicleById(selectedFault.VehicleID);
            if (selectedVehicle == null)
            {
                MessageBox.Show("Не вдалося знайти транспортний засіб, пов'язаний з несправністю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Запитуємо майстра про деталі вирішення проблеми
            var serviceDetails = txtResolvedDescription.Text;
            if (string.IsNullOrWhiteSpace(serviceDetails))
            {
                MessageBox.Show("Будь ласка, заповніть деталі обслуговування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the vehicle service details
            selectedVehicle.LastServiceDate = DateTime.Now;
            selectedVehicle.LastServiceDetails = serviceDetails;
            _vehiclesRepository.UpdateVehicle(selectedVehicle);

            // Видалити запис про несправність
            _faultRepository.DeleteFault(selectedFault.FaultID);

            MessageBox.Show("Несправність успішно вирішена.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtResolvedDescription.Clear();

            // Refresh data
            LoadFaults();
            LoadAssignedVehicles();
        }
    }
}

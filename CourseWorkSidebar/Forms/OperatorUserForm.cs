using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.Forms
{
    public partial class OperatorUserForm : Form
    {
        private readonly DriversRepository _driversRepository;
        private readonly MastersRepository _mastersRepository;
        private readonly VehiclesRepository _vehiclesRepository;
        private readonly FaultRepository _faultRepository;

        public OperatorUserForm()
        {
            InitializeComponent();
            _driversRepository = new DriversRepository();
            _mastersRepository = new MastersRepository();
            _vehiclesRepository = new VehiclesRepository();
            _faultRepository = new FaultRepository();

            LoadAllData();
            btnAssignVehicle.Click += BtnAssignVehicle_Click;
        }

        private void LoadAllData()
        {
            LoadDrivers();
            LoadMasters();
            LoadVehicles();
        }

        private void LoadDrivers()
        {
            var drivers = _driversRepository.GetAllDrivers();
            dataGridViewDrivers.DataSource = drivers;
        }

        private void LoadMasters()
        {
            var masters = _mastersRepository.GetAllMasters();
            dataGridViewMasters.DataSource = masters;
        }

        private void LoadVehicles()
        {
            var vehicles = _vehiclesRepository.GetAllVehicles();
            dataGridViewVehicles.DataSource = vehicles;
        }

        private void BtnAssignVehicle_Click(object sender, EventArgs e)
        {
            var selectedDriver = dataGridViewDrivers.CurrentRow?.DataBoundItem as Driver;
            var selectedVehicle = dataGridViewVehicles.CurrentRow?.DataBoundItem as Vehicle;
            var selectedMaster = dataGridViewMasters.CurrentRow?.DataBoundItem as Master;

            if (selectedDriver == null || selectedVehicle == null || selectedMaster == null)
            {
                MessageBox.Show("Будь ласка, виберіть водія, транспортний засіб і майстра для призначення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedVehicle.DriverID = selectedDriver.DriverID;
            selectedVehicle.AssignedMaster = selectedMaster.MasterID;
            _vehiclesRepository.UpdateVehicle(selectedVehicle);

            MessageBox.Show("Транспортний засіб успішно призначено водію і майстру.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadVehicles();
        }
    }
}

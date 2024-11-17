using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.Forms
{
    public partial class DriverUserForm : Form
    {
        private readonly DriversRepository _driversRepository;
        private readonly VehiclesRepository _vehiclesRepository;
        private readonly FaultRepository _faultRepository;
        private Driver _currentDriver;

        public DriverUserForm(Driver driver)
        {
            InitializeComponent();
            _currentDriver = driver;
            _driversRepository = new DriversRepository();
            _vehiclesRepository = new VehiclesRepository();
            _faultRepository = new FaultRepository();

            LoadDriverSchedule();
            LoadAssignedVehicles();
            btnReportFault.Click += BtnReportFault_Click;
        }

        private void LoadDriverSchedule()
        {
            // Load the driver's schedule from the repository
            var schedule = new List<dynamic> {
                new { Day = "Monday", WorkingArea = _currentDriver.WorkingAreas },
                new { Day = "Tuesday", WorkingArea = _currentDriver.WorkingAreas },
                new { Day = "Wednesday", WorkingArea = _currentDriver.WorkingAreas },
                new { Day = "Thursday", WorkingArea = _currentDriver.WorkingAreas },
                new { Day = "Friday", WorkingArea = _currentDriver.WorkingAreas }
            };

            dataGridViewSchedule.DataSource = schedule;
        }

        private void LoadAssignedVehicles()
        {
            // Load the assigned vehicles for the current driver
            var vehicles = _vehiclesRepository.GetAllVehicles().FindAll(v => v.DriverID == _currentDriver.DriverID);
            dataGridViewVehicles.DataSource = vehicles;
        }

        private void BtnReportFault_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFaultDescription.Text))
            {
                MessageBox.Show("Будь ласка, заповніть опис несправності.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedVehicle = dataGridViewVehicles.CurrentRow?.DataBoundItem as Vehicle;
            if (selectedVehicle == null)
            {
                MessageBox.Show("Будь ласка, виберіть транспортний засіб для повідомлення про несправність.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fault = new Fault
            {
                DriverID = _currentDriver.DriverID,
                VehicleID = selectedVehicle.VehicleID,
                Description = txtFaultDescription.Text,
                ReportDate = DateTime.Now
            };

            _faultRepository.AddFault(fault);
            MessageBox.Show("Несправність успішно повідомлена.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFaultDescription.Clear();
        }
    }
}

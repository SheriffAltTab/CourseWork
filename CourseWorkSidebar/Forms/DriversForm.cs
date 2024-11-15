using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Xml.Linq;

namespace CourseWorkSidebar
{
    public partial class DriversForm : Form
    {
        private readonly DriversRepository _driverRepository;
        private List<Driver> _currentDriverList = new List<Driver>();
        private const string SearchPlaceholder = "Пошук";

        public DriversForm()
        {
            InitializeComponent();
            this.Load += DriversForm_Load;
            _driverRepository = new DriversRepository();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            LoadDrivers();
            InitializeSortOptions();
            SetPlaceholderTexts();
            dataGridViewDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBoxReportFormat.SelectedIndex = 0;
        }

        private void LoadDrivers()
        {
            _currentDriverList = _driverRepository.GetAllDrivers();
            dataGridViewDrivers.DataSource = _currentDriverList;
        }

        private void InitializeSortOptions()
        {
            comboBoxSortBy.Items.Add("ID");
            comboBoxSortBy.Items.Add("Ім'я");
            comboBoxSortBy.Items.Add("Прізвище");
            comboBoxSortBy.Items.Add("Дата народження");
            comboBoxSortBy.Items.Add("Дата прийняття на роботу");
            comboBoxSortBy.Items.Add("Робочі дні");
            comboBoxSortBy.Items.Add("Робочі райони");
            comboBoxSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortBy.SelectedIndex = 0;
        }

        private void SetPlaceholderTexts()
        {
            SetPlaceholder(txtFirstName, "Ім'я");
            SetPlaceholder(txtLastName, "Прізвище");
            SetPlaceholder(txtLicenseNumber, "№ водійського посвідчення");
            SetPlaceholder(txtSearch, SearchPlaceholder);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder && textBox.ForeColor == Color.Gray)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                var driver = new Driver
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value.Date,
                    LicenseNumber = txtLicenseNumber.Text,
                    HireDate = dtpHireDate.Value.Date,
                    WorkingDays = GetCheckedDays(),
                    WorkingAreas = GetCheckedAreas()
                };

                _driverRepository.AddDriver(driver);
                LoadDrivers();
            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.CurrentRow?.DataBoundItem is Driver selectedDriver && IsValidInput())
            {
                selectedDriver.FirstName = txtFirstName.Text;
                selectedDriver.LastName = txtLastName.Text;
                selectedDriver.BirthDate = dtpBirthDate.Value.Date;
                selectedDriver.LicenseNumber = txtLicenseNumber.Text;
                selectedDriver.HireDate = dtpHireDate.Value.Date;
                selectedDriver.WorkingDays = GetCheckedDays();
                selectedDriver.WorkingAreas = GetCheckedAreas();

                _driverRepository.UpdateDriver(selectedDriver);
                LoadDrivers();
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.CurrentRow?.DataBoundItem is Driver selectedDriver)
            {
                _driverRepository.DeleteDriver(selectedDriver.DriverID);
                LoadDrivers();
            }
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            SortDrivers(true);
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            SortDrivers(false);
        }

        private void SortDrivers(bool ascending)
        {
            if (comboBoxSortBy.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть критерій для сортування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortBy = comboBoxSortBy.SelectedItem.ToString();

            switch (sortBy)
            {
                case "Ім'я":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.FirstName).ToList() : _currentDriverList.OrderByDescending(d => d.FirstName).ToList();
                    break;
                case "Прізвище":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.LastName).ToList() : _currentDriverList.OrderByDescending(d => d.LastName).ToList();
                    break;
                case "Дата народження":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.BirthDate).ToList() : _currentDriverList.OrderByDescending(d => d.BirthDate).ToList();
                    break;
                case "Дата прийняття на роботу":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.HireDate).ToList() : _currentDriverList.OrderByDescending(d => d.HireDate).ToList();
                    break;
                case "ID":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.DriverID).ToList() : _currentDriverList.OrderByDescending(d => d.DriverID).ToList();
                    break;
                case "Робочі дні":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.WorkingDays).ToList() : _currentDriverList.OrderByDescending(d => d.WorkingDays).ToList();
                    break;
                case "Робочі райони":
                    _currentDriverList = ascending ? _currentDriverList.OrderBy(d => d.WorkingAreas).ToList() : _currentDriverList.OrderByDescending(d => d.WorkingAreas).ToList();
                    break;
                default:
                    MessageBox.Show("Невідомий критерій сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            dataGridViewDrivers.DataSource = _currentDriverList;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedFormat = comboBoxReportFormat.SelectedItem.ToString();
            switch (selectedFormat)
            {
                case "HTML":
                    GenerateDriverReportHtml();
                    break;
                case "PDF":
                    GenerateDriverReportPdf();
                    break;
                case "CSV":
                    GenerateDriverReportCsv();
                    break;
            }
        }

        private void GenerateDriverReportHtml()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"DriverReport_{timestamp}.html");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head><title>Звіт про водіїв</title></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<h1>Звіт про водіїв</h1>");
                writer.WriteLine("<table border='1'>");
                writer.WriteLine("<tr><th>ID</th><th>Ім'я</th><th>Прізвище</th><th>Дата народження</th><th>№ водійського посвідчення</th><th>Дата прийняття на роботу</th>" +
                    "<th>Робочі дні</th><th>Робочі райони</th></tr>");

                foreach (var driver in _currentDriverList)
                {
                    writer.WriteLine($"<tr><td>{driver.DriverID}</td><td>{driver.FirstName}</td><td>{driver.LastName}</td><td>{driver.BirthDate.ToShortDateString()}</td>" +
                        $"<td>{driver.LicenseNumber}</td><td>{driver.HireDate.ToShortDateString()}</td><td>{driver.WorkingDays}</td><td>{driver.WorkingAreas}</td></tr>");
                }

                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            MessageBox.Show("Звіт збережено як HTML-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateDriverReportPdf()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"DriverReport_{timestamp}.pdf");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var fs = new FileStream(reportPath, FileMode.Create))
            {
                var document = new Document();
                PdfWriter.GetInstance(document, fs);
                document.Open();

                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                var bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                var font = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                var table = new PdfPTable(8);
                table.AddCell(new PdfPCell(new Phrase("ID", font)));
                table.AddCell(new PdfPCell(new Phrase("Ім'я", font)));
                table.AddCell(new PdfPCell(new Phrase("Прізвище", font)));
                table.AddCell(new PdfPCell(new Phrase("Дата народження", font)));
                table.AddCell(new PdfPCell(new Phrase("№ водійського посвідчення", font)));
                table.AddCell(new PdfPCell(new Phrase("Дата прийняття на роботу", font)));
                table.AddCell(new PdfPCell(new Phrase("Робочі дні", font)));
                table.AddCell(new PdfPCell(new Phrase("Робочі райони", font)));

                foreach (var driver in _currentDriverList)
                {
                    table.AddCell(new PdfPCell(new Phrase(driver.DriverID.ToString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.FirstName, font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.LastName, font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.BirthDate.ToShortDateString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.LicenseNumber, font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.HireDate.ToShortDateString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.WorkingDays, font)));
                    table.AddCell(new PdfPCell(new Phrase(driver.WorkingAreas, font)));
                }

                document.Add(table);
                document.Close();
            }

            MessageBox.Show("Звіт збережено як PDF-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateDriverReportCsv()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"DriverReport_{timestamp}.csv");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath, false, Encoding.UTF8))
            {
                writer.WriteLine("ID,Ім'я,Прізвище,Дата народження,№ водійського посвідчення,Дата прийняття на роботу,Робочі дні,Робочі райони");

                foreach (var driver in _currentDriverList)
                {
                    writer.WriteLine($"{driver.DriverID},{driver.FirstName},{driver.LastName},{driver.BirthDate.ToShortDateString()},{driver.LicenseNumber}," +
                        $"{driver.HireDate.ToShortDateString()},{driver.WorkingDays},{driver.WorkingAreas}");
                }
            }

            MessageBox.Show("Звіт збережено як CSV-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void OpenReportInBrowser(string reportPath)
        {
            if (File.Exists(reportPath))
            {
                Process.Start(new ProcessStartInfo(reportPath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Не вдалося знайти звіт.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == SearchPlaceholder)
            {
                LoadDrivers();
                return;
            }

            var searchValue = txtSearch.Text.ToLower();
            _currentDriverList = _driverRepository.GetAllDrivers().Where(d =>
                d.FirstName.ToLower().Contains(searchValue) ||
                d.LastName.ToLower().Contains(searchValue) ||
                d.LicenseNumber.ToLower().Contains(searchValue)).ToList();
            dataGridViewDrivers.DataSource = _currentDriverList;
        }

        private bool IsValidInput()
        {
            if (txtFirstName.ForeColor == Color.Gray || txtLastName.ForeColor == Color.Gray || txtLicenseNumber.ForeColor == Color.Gray)
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private string GetCheckedDays()
        {
            var selectedDays = clbWorkingDays.CheckedItems.Cast<string>().ToArray();
            return string.Join(", ", selectedDays);
        }

        private string GetCheckedAreas()
        {
            var selectedAreas = clbWorkingAreas.CheckedItems.Cast<string>().ToArray();
            return string.Join(", ", selectedAreas);
        }
    }
}

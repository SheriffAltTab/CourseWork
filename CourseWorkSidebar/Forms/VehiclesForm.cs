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
using System.Data;
using iTextSharp.text.pdf;
using System.Xml.Linq;

namespace CourseWorkSidebar
{
    public partial class VehiclesForm : Form
    {
        private readonly VehiclesRepository _vehiclesRepository;
        private List<Vehicle> _currentVehicleList;
        private const string SearchPlaceholder = "Пошук";

        public VehiclesForm()
        {
            InitializeComponent();
            this.Load += VehiclesForm_Load;
            _vehiclesRepository = new VehiclesRepository();
            LoadVehicles();
            InitializeSortOptions();
            InitializeReportFormatOptions();
            dataGridViewVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void LoadVehicles()
        {
            _currentVehicleList = _vehiclesRepository.GetAllVehicles();
            dataGridViewVehicles.DataSource = _currentVehicleList;
        }

        private void InitializeSortOptions()
        {
            comboBoxSortBy.Items.Add("ID");
            comboBoxSortBy.Items.Add("Номерний знак");
            comboBoxSortBy.Items.Add("Марка");
            comboBoxSortBy.Items.Add("Модель");
            comboBoxSortBy.Items.Add("Рік випуску");
            comboBoxSortBy.Items.Add("ID водія");
            comboBoxSortBy.Items.Add("Призначений майстер");
            comboBoxSortBy.Items.Add("Дата тех. обслуговування");
            comboBoxSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortBy.SelectedIndex = 0;
        }

        private void InitializeReportFormatOptions()
        {
            comboBoxReportFormat.Items.Add("HTML");
            comboBoxReportFormat.Items.Add("PDF");
            comboBoxReportFormat.Items.Add("CSV");
            comboBoxReportFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReportFormat.SelectedIndex = 0;
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            SetPlaceholderTexts();
        }

        private void SetPlaceholderTexts()
        {
            SetPlaceholder(txtBrand, "Марка");
            SetPlaceholder(txtModel, "Модель");
            SetPlaceholder(txtYear, "Рік випуску");
            SetPlaceholder(txtLicensePlate, "Номерний знак");
            SetPlaceholder(txtDriverID, "ID водія");
            SetPlaceholder(txtAssignedMaster, "Призначений майстер");
            SetPlaceholder(txtLastServiceDetails, "Опис останнього тех. обслуговування");
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

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            var vehicle = new Vehicle
            {
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Year = int.Parse(txtYear.Text),
                LicensePlate = txtLicensePlate.Text,
                DriverID = string.IsNullOrWhiteSpace(txtDriverID.Text) ? (int?)null : int.Parse(txtDriverID.Text),
                AssignedMaster = string.IsNullOrWhiteSpace(txtAssignedMaster.Text) ? (int?)null : int.Parse(txtAssignedMaster.Text),
                LastServiceDate = dtpLastServiceDate.Value.Date,
                LastServiceDetails = txtLastServiceDetails.Text
            };

            _vehiclesRepository.AddVehicle(vehicle);
            LoadVehicles();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.CurrentRow?.DataBoundItem is Vehicle selectedVehicle)
            {
                selectedVehicle.Brand = txtBrand.Text;
                selectedVehicle.Model = txtModel.Text;
                selectedVehicle.Year = int.Parse(txtYear.Text);
                selectedVehicle.LicensePlate = txtLicensePlate.Text;
                selectedVehicle.DriverID = string.IsNullOrWhiteSpace(txtDriverID.Text) ? (int?)null : int.Parse(txtDriverID.Text);
                selectedVehicle.AssignedMaster = string.IsNullOrWhiteSpace(txtAssignedMaster.Text) ? (int?)null : int.Parse(txtAssignedMaster.Text);
                selectedVehicle.LastServiceDate = dtpLastServiceDate.Value.Date;
                selectedVehicle.LastServiceDetails = txtLastServiceDetails.Text;

                _vehiclesRepository.UpdateVehicle(selectedVehicle);
                LoadVehicles();
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.CurrentRow?.DataBoundItem is Vehicle selectedVehicle)
            {
                _vehiclesRepository.DeleteVehicle(selectedVehicle.VehicleID);
                LoadVehicles();
            }
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            SortVehicles(true);
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            SortVehicles(false);
        }

        private void SortVehicles(bool ascending)
        {
            if (comboBoxSortBy.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть критерій для сортування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sortBy = comboBoxSortBy.SelectedItem.ToString();

            switch (sortBy)
            {
                case "Модель":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.Model).ToList() : _currentVehicleList.OrderByDescending(v => v.Model).ToList();
                    break;
                case "Марка":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.Brand).ToList() : _currentVehicleList.OrderByDescending(v => v.Brand).ToList();
                    break;
                case "Рік випуску":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.Year).ToList() : _currentVehicleList.OrderByDescending(v => v.Year).ToList();
                    break;
                case "Номерний знак":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.LicensePlate).ToList() : _currentVehicleList.OrderByDescending(v => v.LicensePlate).ToList();
                    break;
                case "ID":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.VehicleID).ToList() : _currentVehicleList.OrderByDescending(v => v.VehicleID).ToList();
                    break;
                case "ID водія":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.DriverID).ToList() : _currentVehicleList.OrderByDescending(v => v.DriverID).ToList();
                    break;
                case "Призначений майстер":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.AssignedMaster).ToList() : _currentVehicleList.OrderByDescending(v => v.AssignedMaster).ToList();
                    break;
                case "Дата тех. обслуговування":
                    _currentVehicleList = ascending ? _currentVehicleList.OrderBy(v => v.LastServiceDate).ToList() : _currentVehicleList.OrderByDescending(v => v.LastServiceDate).ToList();
                    break;
                default:
                    MessageBox.Show("Невідомий критерій сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            dataGridViewVehicles.DataSource = _currentVehicleList;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedFormat = comboBoxReportFormat.SelectedItem.ToString();
            switch (selectedFormat)
            {
                case "HTML":
                    GenerateVehicleReportHtml();
                    break;
                case "PDF":
                    GenerateVehicleReportPdf();
                    break;
                case "CSV":
                    GenerateVehicleReportCsv();
                    break;
                default:
                    MessageBox.Show("Невідомий формат звіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void GenerateVehicleReportHtml()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"VehicleReport_{timestamp}.html");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head><title>Звіт про транспортні засоби</title></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<h1>Звіт про транспортні засоби</h1>");
                writer.WriteLine("<table border='1'>");
                writer.WriteLine("<tr><th>ID</th><th>Марка</th><th>Модель</th><th>Рік випуску</th><th>Номерний знак</th><th>ID водія</th>" +
                    "<th>Призначений майстер</th><th>Дата останнього тех. обслуговування</th><th>Опис тех. обслуговування</th></tr>");

                foreach (var vehicle in _currentVehicleList)
                {
                    writer.WriteLine($"<tr><td>{vehicle.VehicleID}</td><td>{vehicle.Brand}</td><td>{vehicle.Model}</td><td>{vehicle.Year}</td><td>{vehicle.LicensePlate}</td>" +
                        $"<td>{vehicle.DriverID}</td><td>{vehicle.AssignedMaster}</td><td>{vehicle.LastServiceDate?.ToString("dd.MM.yyyy") ?? ""}</td>" +
                        $"<td>{vehicle.LastServiceDetails}</td></tr>");
                }

                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            MessageBox.Show("Звіт збережено як HTML-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateVehicleReportPdf()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"VehicleReport_{timestamp}.pdf");

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
                var font = new iTextSharp.text.Font(bf, 9, iTextSharp.text.Font.NORMAL);

                var table = new PdfPTable(9);
                table.AddCell(new PdfPCell(new Phrase("ID", font)));
                table.AddCell(new PdfPCell(new Phrase("Марка", font)));
                table.AddCell(new PdfPCell(new Phrase("Модель", font)));
                table.AddCell(new PdfPCell(new Phrase("Рік випуску", font)));
                table.AddCell(new PdfPCell(new Phrase("Номерний знак", font)));
                table.AddCell(new PdfPCell(new Phrase("ID водія", font)));
                table.AddCell(new PdfPCell(new Phrase("Призначений майстер", font)));
                table.AddCell(new PdfPCell(new Phrase("Дата останнього тех. обслуговування", font)));
                table.AddCell(new PdfPCell(new Phrase("Опис тех. обслуговування", font)));

                foreach (var vehicle in _currentVehicleList)
                {
                    table.AddCell(new PdfPCell(new Phrase(vehicle.VehicleID.ToString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.Brand, font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.Model, font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.Year.ToString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.LicensePlate, font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.DriverID?.ToString() ?? "", font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.AssignedMaster?.ToString() ?? "", font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.LastServiceDate?.ToString("dd.MM.yyyy") ?? "", font)));
                    table.AddCell(new PdfPCell(new Phrase(vehicle.LastServiceDetails?.ToString() ?? "", font)));
                }

                document.Add(table);
                document.Close();
            }

            MessageBox.Show("Звіт збережено як PDF-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateVehicleReportCsv()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"VehicleReport_{timestamp}.csv");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath, false, Encoding.UTF8))
            {
                writer.WriteLine("ID,Марка,Модель,Рік випуску,Номерний знак,ID водія,Призначений майстер,Дата останнього тех. обслуговування,Опис тех. обслуговування");
                foreach (var vehicle in _currentVehicleList)
                {
                    writer.WriteLine($"{vehicle.VehicleID},{vehicle.Brand},{vehicle.Model},{vehicle.Year},{vehicle.LicensePlate},{vehicle.DriverID},{vehicle.AssignedMaster}," +
                        $"{vehicle.LastServiceDate?.ToString("dd.MM.yyyy") ?? ""},{vehicle.LastServiceDetails}");
                }
            }

            MessageBox.Show("Звіт збережено як CSV-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void OpenReportInBrowser(string reportPath)
        {
            if (File.Exists(reportPath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(reportPath) { UseShellExecute = true });
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
                LoadVehicles();
                return;
            }

            var searchValue = txtSearch.Text.ToLower();
            _currentVehicleList = _vehiclesRepository.GetAllVehicles().Where(v =>
                v.Brand.ToLower().Contains(searchValue) ||
                v.Model.ToLower().Contains(searchValue) ||
                v.LicensePlate.ToLower().Contains(searchValue) ||
                v.DriverID.ToString().Contains(searchValue) ||
                v.AssignedMaster.ToString().Contains(searchValue) ||
                v.LastServiceDetails.ToLower().Contains(searchValue)
            ).ToList();
            dataGridViewVehicles.DataSource = _currentVehicleList;
        }
    }
}

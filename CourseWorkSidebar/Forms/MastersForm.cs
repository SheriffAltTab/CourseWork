using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Xml.Linq;

namespace CourseWorkSidebar
{
    public partial class MastersForm : Form
    {
        private readonly MastersRepository _masterRepository;
        private List<Master> _currentMasterList = new List<Master>();
        private const string SearchPlaceholder = "Пошук";

        public MastersForm()
        {
            InitializeComponent();
            this.Load += MastersForm_Load;
            _masterRepository = new MastersRepository();
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // Підключення обробників подій для кнопок
            btnAddMaster.Click += btnAddMaster_Click;
            btnUpdateMaster.Click += btnUpdateMaster_Click;
            btnDeleteMaster.Click += btnDeleteMaster_Click;
            btnSortAscending.Click += btnSortAscending_Click;
            btnSortDescending.Click += btnSortDescending_Click;
            btnGenerateReport.Click += btnGenerateReport_Click;
            btnReturnToMain.Click += btnReturnToMain_Click;
        }

        private void MastersForm_Load(object sender, EventArgs e)
        {
            LoadMasters();
            InitializeSortOptions();
            InitializeReportFormatOptions();
            SetPlaceholderTexts();
            dataGridViewMasters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadMasters()
        {
            _currentMasterList = _masterRepository.GetAllMasters();
            dataGridViewMasters.DataSource = _currentMasterList;
        }

        private void InitializeSortOptions()
        {
            comboBoxSortBy.Items.Add("ID");
            comboBoxSortBy.Items.Add("Ім'я");
            comboBoxSortBy.Items.Add("Прізвище");
            comboBoxSortBy.Items.Add("Дата народження");
            comboBoxSortBy.Items.Add("Дата прийняття на роботу");
            comboBoxSortBy.Items.Add("Спеціальність");
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

        private void SetPlaceholderTexts()
        {
            // Налаштування тексту заповнювача для кожного TextBox
            SetPlaceholder(txtFirstName, "Ім'я");
            SetPlaceholder(txtLastName, "Прізвище");
            SetPlaceholder(txtSpecialty, "Спеціальність");
            SetPlaceholder(txtSearch, SearchPlaceholder);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            // Додаємо обробники подій для фокусу і втрати фокусу
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

        private void btnAddMaster_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                var master = new Master
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value.Date,
                    HireDate = dtpHireDate.Value.Date,
                    Specialty = txtSpecialty.Text
                };

                _masterRepository.AddMaster(master);
                LoadMasters();
            }
        }

        private void btnUpdateMaster_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasters.CurrentRow?.DataBoundItem is Master selectedMaster && IsValidInput())
            {
                selectedMaster.FirstName = txtFirstName.Text;
                selectedMaster.LastName = txtLastName.Text;
                selectedMaster.BirthDate = dtpBirthDate.Value.Date;
                selectedMaster.HireDate = dtpHireDate.Value.Date;
                selectedMaster.Specialty = txtSpecialty.Text;

                _masterRepository.UpdateMaster(selectedMaster);
                LoadMasters();
            }
        }

        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasters.CurrentRow?.DataBoundItem is Master selectedMaster)
            {
                _masterRepository.DeleteMaster(selectedMaster.MasterID);
                LoadMasters();
            }
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            SortMasters(true);
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            SortMasters(false);
        }

        private void SortMasters(bool ascending)
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
                    _currentMasterList = ascending ? _currentMasterList.OrderBy(m => m.FirstName).ToList() : _currentMasterList.OrderByDescending(m => m.FirstName).ToList();
                    break;
                case "Прізвище":
                    _currentMasterList = ascending ? _currentMasterList.OrderBy(m => m.LastName).ToList() : _currentMasterList.OrderByDescending(m => m.LastName).ToList();
                    break;
                case "Дата народження":
                    _currentMasterList = ascending ? _currentMasterList.OrderBy(m => m.BirthDate).ToList() : _currentMasterList.OrderByDescending(m => m.BirthDate).ToList();
                    break;
                case "Дата прийняття на роботу":
                    _currentMasterList = ascending ? _currentMasterList.OrderBy(m => m.HireDate).ToList() : _currentMasterList.OrderByDescending(m => m.HireDate).ToList();
                    break;
                case "Спеціальність":
                    _currentMasterList = ascending ? _currentMasterList.OrderBy(m => m.Specialty).ToList() : _currentMasterList.OrderByDescending(m => m.Specialty).ToList();
                    break;
                case "ID":
                    _currentMasterList = ascending ? _currentMasterList.OrderBy(m => m.MasterID).ToList() : _currentMasterList.OrderByDescending(m => m.MasterID).ToList();
                    break;
                default:
                    MessageBox.Show("Невідомий критерій сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            dataGridViewMasters.DataSource = _currentMasterList;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == SearchPlaceholder)
            {
                LoadMasters();
                return;
            }

            var searchValue = txtSearch.Text.ToLower();
            _currentMasterList = _masterRepository.GetAllMasters().Where(m =>
                m.FirstName.ToLower().Contains(searchValue) ||
                m.LastName.ToLower().Contains(searchValue) ||
                m.Specialty.ToLower().Contains(searchValue)).ToList();
            dataGridViewMasters.DataSource = _currentMasterList;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedFormat = comboBoxReportFormat.SelectedItem.ToString();
            switch (selectedFormat)
            {
                case "HTML":
                    GenerateMasterReportHtml();
                    break;
                case "PDF":
                    GenerateMasterReportPdf();
                    break;
                case "CSV":
                    GenerateMasterReportCsv();
                    break;
                default:
                    MessageBox.Show("Невідомий формат звіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void GenerateMasterReportHtml()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"MasterReport_{timestamp}.html");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head><title>Звіт про майстрів</title></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<h1>Звіт про майстрів</h1>");
                writer.WriteLine("<table border='1'>");
                writer.WriteLine("<tr><th>ID</th><th>Ім'я</th><th>Прізвище</th><th>Дата народження</th><th>Спеціальність</th><th>Дата прийняття на роботу</th></tr>");

                foreach (var master in _currentMasterList)
                {
                    writer.WriteLine($"<tr><td>{master.MasterID}</td><td>{master.FirstName}</td><td>{master.LastName}</td><td>{master.BirthDate.ToShortDateString()}</td><td>{master.Specialty}</td><td>{master.HireDate.ToShortDateString()}</td></tr>");
                }

                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            MessageBox.Show("Звіт збережено як HTML-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateMasterReportPdf()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"MasterReport_{timestamp}.pdf");

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

                var table = new PdfPTable(6);
                table.AddCell(new PdfPCell(new Phrase("ID", font)));
                table.AddCell(new PdfPCell(new Phrase("Ім'я", font)));
                table.AddCell(new PdfPCell(new Phrase("Прізвище", font)));
                table.AddCell(new PdfPCell(new Phrase("Дата народження", font)));
                table.AddCell(new PdfPCell(new Phrase("Спеціальність", font)));
                table.AddCell(new PdfPCell(new Phrase("Дата прийняття на роботу", font)));

                foreach (var master in _currentMasterList)
                {
                    table.AddCell(new PdfPCell(new Phrase(master.MasterID.ToString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(master.FirstName, font)));
                    table.AddCell(new PdfPCell(new Phrase(master.LastName, font)));
                    table.AddCell(new PdfPCell(new Phrase(master.BirthDate.ToShortDateString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(master.Specialty, font)));
                    table.AddCell(new PdfPCell(new Phrase(master.HireDate.ToShortDateString(), font)));
                }

                document.Add(table);
                document.Close();
            }

            MessageBox.Show("Звіт збережено як PDF-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateMasterReportCsv()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"MasterReport_{timestamp}.csv");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath, false, Encoding.UTF8))
            {
                writer.WriteLine("ID,Ім'я,Прізвище,Дата народження,Спеціальність,Дата прийняття на роботу");
                foreach (var master in _currentMasterList)
                {
                    writer.WriteLine($"{master.MasterID},{master.FirstName},{master.LastName},{master.BirthDate.ToShortDateString()},{master.Specialty},{master.HireDate.ToShortDateString()}");
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

        private bool IsValidInput()
        {
            if (txtFirstName.ForeColor == Color.Gray || txtLastName.ForeColor == Color.Gray || txtSpecialty.ForeColor == Color.Gray)
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

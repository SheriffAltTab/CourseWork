using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;
using System.Drawing;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Xml.Linq;
using System.Diagnostics.Metrics;

namespace CourseWorkSidebar
{
    public partial class OperatorsForm : Form
    {
        private readonly OperatorsRepository _operatorsRepository;
        private List<Operator> _currentOperatorList = new List<Operator>();
        private const string SearchPlaceholder = "Пошук";

        public OperatorsForm()
        {
            InitializeComponent();
            this.Load += OperatorsForm_Load;
            _operatorsRepository = new OperatorsRepository();
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void OperatorsForm_Load(object sender, EventArgs e)
        {
            LoadOperators();
            InitializeSortOptions();
            InitializeReportFormatOptions();
            SetPlaceholderTexts();
            dataGridViewOperators.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadOperators()
        {
            _currentOperatorList = _operatorsRepository.GetAllOperators();
            dataGridViewOperators.DataSource = _currentOperatorList;
        }

        private void InitializeSortOptions()
        {
            comboBoxSortBy.Items.Add("ID");
            comboBoxSortBy.Items.Add("Ім'я");
            comboBoxSortBy.Items.Add("Прізвище");
            comboBoxSortBy.Items.Add("Дата народження");
            comboBoxSortBy.Items.Add("Дата прийняття на роботу");
            comboBoxSortBy.Items.Add("Робочі дні");
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
            SetPlaceholder(txtFirstName, "Ім'я");
            SetPlaceholder(txtLastName, "Прізвище");
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

        private void btnAddOperator_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                var newOperator = new Operator
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value.Date,
                    HireDate = dtpHireDate.Value.Date,
                    WorkingDays = GetCheckedDays()
                };

                _operatorsRepository.AddOperator(newOperator);
                LoadOperators();
            }
        }

        private void btnUpdateOperator_Click(object sender, EventArgs e)
        {
            if (dataGridViewOperators.CurrentRow?.DataBoundItem is Operator selectedOperator && IsValidInput())
            {
                selectedOperator.FirstName = txtFirstName.Text;
                selectedOperator.LastName = txtLastName.Text;
                selectedOperator.BirthDate = dtpBirthDate.Value.Date;
                selectedOperator.HireDate = dtpHireDate.Value.Date;
                selectedOperator.WorkingDays = GetCheckedDays();

                _operatorsRepository.UpdateOperator(selectedOperator);
                LoadOperators();
            }
        }

        private void btnDeleteOperator_Click(object sender, EventArgs e)
        {
            if (dataGridViewOperators.CurrentRow?.DataBoundItem is Operator selectedOperator)
            {
                _operatorsRepository.DeleteOperator(selectedOperator.OperatorID);
                LoadOperators();
            }
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            SortOperators(true);
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            SortOperators(false);
        }

        private void SortOperators(bool ascending)
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
                    _currentOperatorList = ascending ? _currentOperatorList.OrderBy(o => o.FirstName).ToList() : _currentOperatorList.OrderByDescending(o => o.FirstName).ToList();
                    break;
                case "Прізвище":
                    _currentOperatorList = ascending ? _currentOperatorList.OrderBy(o => o.LastName).ToList() : _currentOperatorList.OrderByDescending(o => o.LastName).ToList();
                    break;
                case "Дата народження":
                    _currentOperatorList = ascending ? _currentOperatorList.OrderBy(o => o.BirthDate).ToList() : _currentOperatorList.OrderByDescending(o => o.BirthDate).ToList();
                    break;
                case "Дата прийняття на роботу":
                    _currentOperatorList = ascending ? _currentOperatorList.OrderBy(o => o.HireDate).ToList() : _currentOperatorList.OrderByDescending(o => o.HireDate).ToList();
                    break;
                case "ID":
                    _currentOperatorList = ascending ? _currentOperatorList.OrderBy(o => o.OperatorID).ToList() : _currentOperatorList.OrderByDescending(o => o.OperatorID).ToList();
                    break;
                case "Робочі дні":
                    _currentOperatorList = ascending ? _currentOperatorList.OrderBy(o => o.WorkingDays).ToList() : _currentOperatorList.OrderByDescending(o => o.WorkingDays).ToList();
                    break;
                default:
                    MessageBox.Show("Невідомий критерій сортування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            dataGridViewOperators.DataSource = _currentOperatorList;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == SearchPlaceholder)
            {
                LoadOperators();
                return;
            }

            var searchValue = txtSearch.Text.ToLower();
            _currentOperatorList = _operatorsRepository.GetAllOperators().Where(o =>
                o.FirstName.ToLower().Contains(searchValue) ||
                o.LastName.ToLower().Contains(searchValue)).ToList();
            dataGridViewOperators.DataSource = _currentOperatorList;
        }

        private bool IsValidInput()
        {
            if (txtFirstName.ForeColor == Color.Gray || txtLastName.ForeColor == Color.Gray)
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedFormat = comboBoxReportFormat.SelectedItem.ToString();
            switch (selectedFormat)
            {
                case "HTML":
                    GenerateOperatorReportHtml();
                    break;
                case "PDF":
                    GenerateOperatorReportPdf();
                    break;
                case "CSV":
                    GenerateOperatorReportCsv();
                    break;
                default:
                    MessageBox.Show("Невідомий формат звіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void GenerateOperatorReportHtml()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"OperatorReport_{timestamp}.html");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head><title>Звіт про операторів</title></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<h1>Звіт про операторів</h1>");
                writer.WriteLine("<table border='1'>");
                writer.WriteLine("<tr><th>ID</th><th>Ім'я</th><th>Прізвище</th><th>Дата народження</th><th>Дата прийняття на роботу</th><th>Робочі дні</th></tr>");

                foreach (var operatorData in _currentOperatorList)
                {
                    writer.WriteLine($"<tr><td>{operatorData.OperatorID}</td><td>{operatorData.FirstName}</td><td>{operatorData.LastName}</td>" +
                        $"<td>{operatorData.BirthDate.ToShortDateString()}</td><td>{operatorData.HireDate.ToShortDateString()}</td><td>{operatorData.WorkingDays}</td></tr>");
                }

                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            MessageBox.Show("Звіт збережено як HTML-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateOperatorReportPdf()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"OperatorReport_{timestamp}.pdf");

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
                table.AddCell(new PdfPCell(new Phrase("Дата прийняття на роботу", font)));
                table.AddCell(new PdfPCell(new Phrase("Робочі дні", font)));

                foreach (var operatorData in _currentOperatorList)
                {
                    table.AddCell(new PdfPCell(new Phrase(operatorData.OperatorID.ToString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(operatorData.FirstName, font)));
                    table.AddCell(new PdfPCell(new Phrase(operatorData.LastName, font)));
                    table.AddCell(new PdfPCell(new Phrase(operatorData.BirthDate.ToShortDateString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(operatorData.HireDate.ToShortDateString(), font)));
                    table.AddCell(new PdfPCell(new Phrase(operatorData.WorkingDays, font)));
                }

                document.Add(table);
                document.Close();
            }

            MessageBox.Show("Звіт збережено як PDF-файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenReportInBrowser(reportPath);
        }

        private void GenerateOperatorReportCsv()
        {
            var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Reports");
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var reportPath = Path.Combine(reportDirectory, $"OperatorReport_{timestamp}.csv");

            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            using (var writer = new StreamWriter(reportPath, false, Encoding.UTF8))
            {
                writer.WriteLine("ID,Ім'я,Прізвище,Дата народження,Дата прийняття на роботу");
                foreach (var operatorData in _currentOperatorList)
                {
                    writer.WriteLine($"{operatorData.OperatorID},{operatorData.FirstName},{operatorData.LastName},{operatorData.BirthDate.ToShortDateString()}," +
                        $"{operatorData.HireDate.ToShortDateString()},{operatorData.WorkingDays}");
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

        private string GetCheckedDays()
        {
            var selectedDays = clbWorkingDays.CheckedItems.Cast<string>().ToArray();
            return string.Join(", ", selectedDays);
        }
    }
}

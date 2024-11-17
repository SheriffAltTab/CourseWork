using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar
{
    partial class OperatorsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewOperators;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpHireDate;
        private Button btnAddOperator;
        private Button btnUpdateOperator;
        private Button btnDeleteOperator;
        private TextBox txtSearch;
        private ComboBox comboBoxSortBy;
        private Button btnSortDescending;
        private Button btnSortAscending;
        private TableLayoutPanel tableLayoutPanel;
        private Button btnGenerateReport;
        private ComboBox comboBoxReportFormat;
        private System.Windows.Forms.CheckedListBox clbWorkingDays;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorsForm));
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddOperator = new System.Windows.Forms.Button();
            this.btnUpdateOperator = new System.Windows.Forms.Button();
            this.btnDeleteOperator = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxReportFormat = new System.Windows.Forms.ComboBox();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clbWorkingDays = new System.Windows.Forms.CheckedListBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewOperators, 5);
            this.dataGridViewOperators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOperators.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewOperators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            this.dataGridViewOperators.RowHeadersWidth = 51;
            this.dataGridViewOperators.RowTemplate.Height = 29;
            this.dataGridViewOperators.Size = new System.Drawing.Size(1061, 252);
            this.dataGridViewOperators.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(3, 258);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(207, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(216, 258);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthDate.Location = new System.Drawing.Point(429, 258);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(207, 22);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHireDate.Location = new System.Drawing.Point(642, 258);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(207, 22);
            this.dtpHireDate.TabIndex = 4;
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOperator.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOperator.Image")));
            this.btnAddOperator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOperator.Location = new System.Drawing.Point(3, 290);
            this.btnAddOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.Size = new System.Drawing.Size(207, 61);
            this.btnAddOperator.TabIndex = 5;
            this.btnAddOperator.Text = "Додати оператора";
            this.btnAddOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddOperator.UseVisualStyleBackColor = true;
            this.btnAddOperator.Click += new System.EventHandler(this.btnAddOperator_Click);
            // 
            // btnUpdateOperator
            // 
            this.btnUpdateOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateOperator.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateOperator.Image")));
            this.btnUpdateOperator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateOperator.Location = new System.Drawing.Point(216, 290);
            this.btnUpdateOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateOperator.Name = "btnUpdateOperator";
            this.btnUpdateOperator.Size = new System.Drawing.Size(207, 61);
            this.btnUpdateOperator.TabIndex = 6;
            this.btnUpdateOperator.Text = "Оновити оператора";
            this.btnUpdateOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateOperator.UseVisualStyleBackColor = true;
            this.btnUpdateOperator.Click += new System.EventHandler(this.btnUpdateOperator_Click);
            // 
            // btnDeleteOperator
            // 
            this.btnDeleteOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteOperator.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOperator.Image")));
            this.btnDeleteOperator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteOperator.Location = new System.Drawing.Point(429, 290);
            this.btnDeleteOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteOperator.Name = "btnDeleteOperator";
            this.btnDeleteOperator.Size = new System.Drawing.Size(207, 61);
            this.btnDeleteOperator.TabIndex = 7;
            this.btnDeleteOperator.Text = "Видалити оператора";
            this.btnDeleteOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteOperator.UseVisualStyleBackColor = true;
            this.btnDeleteOperator.Click += new System.EventHandler(this.btnDeleteOperator_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(642, 290);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // comboBoxSortBy
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxSortBy, 2);
            this.comboBoxSortBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(3, 355);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(420, 24);
            this.comboBoxSortBy.TabIndex = 10;
            // 
            // comboBoxReportFormat
            // 
            this.comboBoxReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportFormat.FormattingEnabled = true;
            this.comboBoxReportFormat.Location = new System.Drawing.Point(642, 355);
            this.comboBoxReportFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxReportFormat.Name = "comboBoxReportFormat";
            this.comboBoxReportFormat.Size = new System.Drawing.Size(207, 24);
            this.comboBoxReportFormat.TabIndex = 9;
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortDescending.Image = ((System.Drawing.Image)(resources.GetObject("btnSortDescending.Image")));
            this.btnSortDescending.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortDescending.Location = new System.Drawing.Point(3, 387);
            this.btnSortDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(207, 61);
            this.btnSortDescending.TabIndex = 11;
            this.btnSortDescending.Text = "Сортувати";
            this.btnSortDescending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortDescending.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAscending.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAscending.Image")));
            this.btnSortAscending.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortAscending.Location = new System.Drawing.Point(216, 387);
            this.btnSortAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(207, 61);
            this.btnSortAscending.TabIndex = 12;
            this.btnSortAscending.Text = "Сортувати";
            this.btnSortAscending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortAscending.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewOperators, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtFirstName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dtpBirthDate, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.dtpHireDate, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.clbWorkingDays, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAddOperator, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnUpdateOperator, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteOperator, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxReportFormat, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxSortBy, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnSortDescending, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnSortAscending, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnGenerateReport, 3, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1067, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // clbWorkingDays
            // 
            this.clbWorkingDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbWorkingDays.FormattingEnabled = true;
            this.clbWorkingDays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Нд"});
            this.clbWorkingDays.Location = new System.Drawing.Point(855, 258);
            this.clbWorkingDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbWorkingDays.Name = "clbWorkingDays";
            this.tableLayoutPanel.SetRowSpan(this.clbWorkingDays, 4);
            this.clbWorkingDays.Size = new System.Drawing.Size(209, 190);
            this.clbWorkingDays.TabIndex = 17;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateReport.Location = new System.Drawing.Point(642, 387);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(207, 61);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Генерувати звіт";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // OperatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OperatorsForm";
            this.Text = "Управління операторами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

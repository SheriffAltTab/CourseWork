using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar
{
    partial class DriversForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewDrivers;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox comboBoxReportFormat;
        private System.Windows.Forms.CheckedListBox clbWorkingDays;
        private System.Windows.Forms.CheckedListBox clbWorkingAreas;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clbWorkingDays = new System.Windows.Forms.CheckedListBox();
            this.clbWorkingAreas = new System.Windows.Forms.CheckedListBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxReportFormat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewDrivers, 7);
            this.dataGridViewDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDrivers.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewDrivers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.RowHeadersWidth = 51;
            this.dataGridViewDrivers.RowTemplate.Height = 29;
            this.dataGridViewDrivers.Size = new System.Drawing.Size(1061, 318);
            this.dataGridViewDrivers.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(3, 324);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(163, 324);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthDate.Location = new System.Drawing.Point(323, 324);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(154, 22);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicenseNumber.Location = new System.Drawing.Point(483, 324);
            this.txtLicenseNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(154, 22);
            this.txtLicenseNumber.TabIndex = 4;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHireDate.Location = new System.Drawing.Point(643, 324);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(154, 22);
            this.dtpHireDate.TabIndex = 5;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDriver.Location = new System.Drawing.Point(3, 356);
            this.btnAddDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(154, 28);
            this.btnAddDriver.TabIndex = 6;
            this.btnAddDriver.Text = "Додати водія";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDriver.Location = new System.Drawing.Point(163, 356);
            this.btnUpdateDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(154, 28);
            this.btnUpdateDriver.TabIndex = 7;
            this.btnUpdateDriver.Text = "Оновити водія";
            this.btnUpdateDriver.UseVisualStyleBackColor = true;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDriver.Location = new System.Drawing.Point(323, 356);
            this.btnDeleteDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(154, 28);
            this.btnDeleteDriver.TabIndex = 8;
            this.btnDeleteDriver.Text = "Видалити водія";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // txtSearch
            // 
            this.tableLayoutPanel.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(483, 356);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // comboBoxSortBy
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxSortBy, 2);
            this.comboBoxSortBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(3, 388);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(314, 24);
            this.comboBoxSortBy.TabIndex = 11;
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortDescending.Location = new System.Drawing.Point(3, 420);
            this.btnSortDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(154, 28);
            this.btnSortDescending.TabIndex = 12;
            this.btnSortDescending.Text = "Сортувати ↑";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAscending.Location = new System.Drawing.Point(163, 420);
            this.btnSortAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(154, 28);
            this.btnSortAscending.TabIndex = 13;
            this.btnSortAscending.Text = "Сортувати ↓";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewDrivers, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtFirstName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dtpBirthDate, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.txtLicenseNumber, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.dtpHireDate, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.clbWorkingDays, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.clbWorkingAreas, 6, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAddDriver, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnUpdateDriver, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteDriver, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxSortBy, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnSortDescending, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnSortAscending, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnGenerateReport, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.comboBoxReportFormat, 3, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.clbWorkingDays.Location = new System.Drawing.Point(803, 324);
            this.clbWorkingDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbWorkingDays.Name = "clbWorkingDays";
            this.tableLayoutPanel.SetRowSpan(this.clbWorkingDays, 4);
            this.clbWorkingDays.Size = new System.Drawing.Size(100, 124);
            this.clbWorkingDays.TabIndex = 17;
            // 
            // clbWorkingAreas
            // 
            this.clbWorkingAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbWorkingAreas.FormattingEnabled = true;
            this.clbWorkingAreas.Items.AddRange(new object[] {
            "Центр",
            "Дружба",
            "Новий світ",
            "Кутківці",
            "Канада",
            "Промисловий",
            "Кленовий гай",
            "Східний",
            "Аляска",
            "Сонячний",
            "Березовиця"});
            this.clbWorkingAreas.Location = new System.Drawing.Point(909, 324);
            this.clbWorkingAreas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbWorkingAreas.Name = "clbWorkingAreas";
            this.tableLayoutPanel.SetRowSpan(this.clbWorkingAreas, 4);
            this.clbWorkingAreas.Size = new System.Drawing.Size(155, 124);
            this.clbWorkingAreas.TabIndex = 18;
            // 
            // btnGenerateReport
            // 
            this.tableLayoutPanel.SetColumnSpan(this.btnGenerateReport, 2);
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Location = new System.Drawing.Point(483, 420);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(314, 28);
            this.btnGenerateReport.TabIndex = 15;
            this.btnGenerateReport.Text = "Генерувати звіт";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // comboBoxReportFormat
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxReportFormat, 2);
            this.comboBoxReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportFormat.FormattingEnabled = true;
            this.comboBoxReportFormat.Items.AddRange(new object[] {
            "HTML",
            "PDF",
            "CSV"});
            this.comboBoxReportFormat.Location = new System.Drawing.Point(483, 388);
            this.comboBoxReportFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxReportFormat.Name = "comboBoxReportFormat";
            this.comboBoxReportFormat.Size = new System.Drawing.Size(314, 24);
            this.comboBoxReportFormat.TabIndex = 16;
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DriversForm";
            this.Text = "Управління водіями";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

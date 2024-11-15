﻿using System.Drawing;
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
        private Button btnReturnToMain;
        private ComboBox comboBoxSortBy;
        private Button btnSortDescending;
        private Button btnSortAscending;
        private TableLayoutPanel tableLayoutPanel;
        private Button btnGenerateReport;
        private ComboBox comboBoxReportFormat;

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
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddOperator = new System.Windows.Forms.Button();
            this.btnUpdateOperator = new System.Windows.Forms.Button();
            this.btnDeleteOperator = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxReportFormat = new System.Windows.Forms.ComboBox();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.dataGridViewOperators.Size = new System.Drawing.Size(1061, 318);
            this.dataGridViewOperators.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(3, 324);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(207, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(216, 324);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthDate.Location = new System.Drawing.Point(429, 324);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(207, 22);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHireDate.Location = new System.Drawing.Point(642, 324);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(207, 22);
            this.dtpHireDate.TabIndex = 4;
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOperator.Location = new System.Drawing.Point(3, 356);
            this.btnAddOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.Size = new System.Drawing.Size(207, 28);
            this.btnAddOperator.TabIndex = 5;
            this.btnAddOperator.Text = "Додати оператора";
            this.btnAddOperator.UseVisualStyleBackColor = true;
            this.btnAddOperator.Click += new System.EventHandler(this.btnAddOperator_Click);
            // 
            // btnUpdateOperator
            // 
            this.btnUpdateOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateOperator.Location = new System.Drawing.Point(216, 356);
            this.btnUpdateOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateOperator.Name = "btnUpdateOperator";
            this.btnUpdateOperator.Size = new System.Drawing.Size(207, 28);
            this.btnUpdateOperator.TabIndex = 6;
            this.btnUpdateOperator.Text = "Оновити оператора";
            this.btnUpdateOperator.UseVisualStyleBackColor = true;
            this.btnUpdateOperator.Click += new System.EventHandler(this.btnUpdateOperator_Click);
            // 
            // btnDeleteOperator
            // 
            this.btnDeleteOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteOperator.Location = new System.Drawing.Point(429, 356);
            this.btnDeleteOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteOperator.Name = "btnDeleteOperator";
            this.btnDeleteOperator.Size = new System.Drawing.Size(207, 28);
            this.btnDeleteOperator.TabIndex = 7;
            this.btnDeleteOperator.Text = "Видалити оператора";
            this.btnDeleteOperator.UseVisualStyleBackColor = true;
            this.btnDeleteOperator.Click += new System.EventHandler(this.btnDeleteOperator_Click);
            // 
            // txtSearch
            // 
            this.tableLayoutPanel.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(642, 356);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(422, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnToMain.Location = new System.Drawing.Point(855, 420);
            this.btnReturnToMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(209, 28);
            this.btnReturnToMain.TabIndex = 14;
            this.btnReturnToMain.Text = "Назад";
            this.btnReturnToMain.UseVisualStyleBackColor = true;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // comboBoxSortBy
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxSortBy, 2);
            this.comboBoxSortBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(3, 388);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(420, 24);
            this.comboBoxSortBy.TabIndex = 10;
            // 
            // comboBoxReportFormat
            // 
            this.comboBoxReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportFormat.FormattingEnabled = true;
            this.comboBoxReportFormat.Location = new System.Drawing.Point(642, 388);
            this.comboBoxReportFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxReportFormat.Name = "comboBoxReportFormat";
            this.comboBoxReportFormat.Size = new System.Drawing.Size(207, 24);
            this.comboBoxReportFormat.TabIndex = 9;
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortDescending.Location = new System.Drawing.Point(3, 420);
            this.btnSortDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(207, 28);
            this.btnSortDescending.TabIndex = 11;
            this.btnSortDescending.Text = "Сортувати ↑";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAscending.Location = new System.Drawing.Point(216, 420);
            this.btnSortAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(207, 28);
            this.btnSortAscending.TabIndex = 12;
            this.btnSortAscending.Text = "Сортувати ↓";
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
            this.tableLayoutPanel.Controls.Add(this.btnAddOperator, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnUpdateOperator, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteOperator, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxReportFormat, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxSortBy, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnSortDescending, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnSortAscending, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnGenerateReport, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.btnReturnToMain, 4, 4);
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(1067, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Location = new System.Drawing.Point(642, 420);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(207, 28);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Генерувати звіт";
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
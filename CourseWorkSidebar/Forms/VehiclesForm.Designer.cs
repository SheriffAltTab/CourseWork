using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar
{
    partial class VehiclesForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.txtAssignedMaster = new System.Windows.Forms.TextBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxReportFormat = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewVehicles, 6);
            this.dataGridViewVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.RowHeadersWidth = 51;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1268, 318);
            this.dataGridViewVehicles.TabIndex = 0;
            // 
            // txtBrand
            // 
            this.txtBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrand.Location = new System.Drawing.Point(3, 324);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(206, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModel.Location = new System.Drawing.Point(215, 324);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(206, 22);
            this.txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Location = new System.Drawing.Point(427, 324);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(206, 22);
            this.txtYear.TabIndex = 3;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicensePlate.Location = new System.Drawing.Point(639, 324);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(206, 22);
            this.txtLicensePlate.TabIndex = 4;
            // 
            // txtDriverID
            // 
            this.txtDriverID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDriverID.Location = new System.Drawing.Point(851, 324);
            this.txtDriverID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.Size = new System.Drawing.Size(206, 22);
            this.txtDriverID.TabIndex = 5;
            // 
            // txtAssignedMaster
            // 
            this.txtAssignedMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAssignedMaster.Location = new System.Drawing.Point(1063, 324);
            this.txtAssignedMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssignedMaster.Name = "txtAssignedMaster";
            this.txtAssignedMaster.Size = new System.Drawing.Size(208, 22);
            this.txtAssignedMaster.TabIndex = 6;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddVehicle.Location = new System.Drawing.Point(3, 356);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(206, 28);
            this.btnAddVehicle.TabIndex = 7;
            this.btnAddVehicle.Text = "Додати автомобіль";
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateVehicle.Location = new System.Drawing.Point(215, 356);
            this.btnUpdateVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(206, 28);
            this.btnUpdateVehicle.TabIndex = 8;
            this.btnUpdateVehicle.Text = "Оновити автомобіль";
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(427, 356);
            this.btnDeleteVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(206, 28);
            this.btnDeleteVehicle.TabIndex = 9;
            this.btnDeleteVehicle.Text = "Видалити автомобіль";
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // txtSearch
            // 
            this.tableLayoutPanel.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(851, 356);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnToMain.Location = new System.Drawing.Point(1063, 420);
            this.btnReturnToMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(208, 28);
            this.btnReturnToMain.TabIndex = 15;
            this.btnReturnToMain.Text = "Назад";
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // comboBoxSortBy
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxSortBy, 2);
            this.comboBoxSortBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSortBy.Location = new System.Drawing.Point(3, 388);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(418, 24);
            this.comboBoxSortBy.TabIndex = 16;
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAscending.Location = new System.Drawing.Point(3, 420);
            this.btnSortAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(206, 28);
            this.btnSortAscending.TabIndex = 13;
            this.btnSortAscending.Text = "Сортувати ↑";
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortDescending.Location = new System.Drawing.Point(215, 420);
            this.btnSortDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(206, 28);
            this.btnSortDescending.TabIndex = 14;
            this.btnSortDescending.Text = "Сортувати ↓";
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Location = new System.Drawing.Point(851, 420);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(206, 28);
            this.btnGenerateReport.TabIndex = 11;
            this.btnGenerateReport.Text = "Генерувати звіт";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // comboBoxReportFormat
            // 
            this.comboBoxReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportFormat.Location = new System.Drawing.Point(851, 388);
            this.comboBoxReportFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxReportFormat.Name = "comboBoxReportFormat";
            this.comboBoxReportFormat.Size = new System.Drawing.Size(206, 24);
            this.comboBoxReportFormat.TabIndex = 12;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewVehicles, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtBrand, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtModel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txtYear, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.txtLicensePlate, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.txtDriverID, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.txtAssignedMaster, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAddVehicle, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnUpdateVehicle, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteVehicle, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 4, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxReportFormat, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxSortBy, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnSortAscending, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnSortDescending, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnGenerateReport, 4, 4);
            this.tableLayoutPanel.Controls.Add(this.btnReturnToMain, 5, 4);
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(1274, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VehiclesForm";
            this.Text = "Управління транспортними засобами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.TextBox txtAssignedMaster; // Додаємо новий елемент txtAssignedMaster
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnReturnToMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox comboBoxReportFormat;
    }
}

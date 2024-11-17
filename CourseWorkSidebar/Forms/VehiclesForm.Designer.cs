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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesForm));
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.txtAssignedMaster = new System.Windows.Forms.TextBox();
            this.dtpLastServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastServiceDetails = new System.Windows.Forms.TextBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewVehicles, 4);
            this.dataGridViewVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.RowHeadersWidth = 51;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1268, 290);
            this.dataGridViewVehicles.TabIndex = 0;
            // 
            // txtBrand
            // 
            this.txtBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrand.Location = new System.Drawing.Point(3, 296);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(312, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModel.Location = new System.Drawing.Point(321, 296);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(312, 22);
            this.txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Location = new System.Drawing.Point(639, 296);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(312, 22);
            this.txtYear.TabIndex = 3;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicensePlate.Location = new System.Drawing.Point(957, 296);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(314, 22);
            this.txtLicensePlate.TabIndex = 4;
            // 
            // txtDriverID
            // 
            this.txtDriverID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDriverID.Location = new System.Drawing.Point(3, 328);
            this.txtDriverID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.Size = new System.Drawing.Size(312, 22);
            this.txtDriverID.TabIndex = 5;
            // 
            // txtAssignedMaster
            // 
            this.txtAssignedMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAssignedMaster.Location = new System.Drawing.Point(321, 328);
            this.txtAssignedMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssignedMaster.Name = "txtAssignedMaster";
            this.txtAssignedMaster.Size = new System.Drawing.Size(312, 22);
            this.txtAssignedMaster.TabIndex = 6;
            // 
            // dtpLastServiceDate
            // 
            this.dtpLastServiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpLastServiceDate.Location = new System.Drawing.Point(639, 328);
            this.dtpLastServiceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpLastServiceDate.Name = "dtpLastServiceDate";
            this.dtpLastServiceDate.Size = new System.Drawing.Size(312, 22);
            this.dtpLastServiceDate.TabIndex = 7;
            // 
            // txtLastServiceDetails
            // 
            this.txtLastServiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastServiceDetails.Location = new System.Drawing.Point(957, 328);
            this.txtLastServiceDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastServiceDetails.Name = "txtLastServiceDetails";
            this.txtLastServiceDetails.Size = new System.Drawing.Size(314, 22);
            this.txtLastServiceDetails.TabIndex = 8;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddVehicle.Image")));
            this.btnAddVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVehicle.Location = new System.Drawing.Point(3, 360);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(312, 61);
            this.btnAddVehicle.TabIndex = 9;
            this.btnAddVehicle.Text = "Додати автомобіль";
            this.btnAddVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateVehicle.Image")));
            this.btnUpdateVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateVehicle.Location = new System.Drawing.Point(321, 360);
            this.btnUpdateVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(312, 61);
            this.btnUpdateVehicle.TabIndex = 10;
            this.btnUpdateVehicle.Text = "Оновити автомобіль";
            this.btnUpdateVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteVehicle.Image")));
            this.btnDeleteVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(639, 360);
            this.btnDeleteVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(312, 61);
            this.btnDeleteVehicle.TabIndex = 11;
            this.btnDeleteVehicle.Text = "Видалити автомобіль";
            this.btnDeleteVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(957, 360);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // comboBoxSortBy
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxSortBy, 2);
            this.comboBoxSortBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSortBy.Location = new System.Drawing.Point(3, 425);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(630, 24);
            this.comboBoxSortBy.TabIndex = 17;
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAscending.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAscending.Image")));
            this.btnSortAscending.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortAscending.Location = new System.Drawing.Point(321, 457);
            this.btnSortAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(312, 61);
            this.btnSortAscending.TabIndex = 14;
            this.btnSortAscending.Text = "Сортувати";
            this.btnSortAscending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortAscending.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortDescending.Image = ((System.Drawing.Image)(resources.GetObject("btnSortDescending.Image")));
            this.btnSortDescending.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortDescending.Location = new System.Drawing.Point(3, 457);
            this.btnSortDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(312, 61);
            this.btnSortDescending.TabIndex = 15;
            this.btnSortDescending.Text = "Сортувати";
            this.btnSortDescending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortDescending.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateReport.Location = new System.Drawing.Point(957, 457);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(314, 61);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Генерувати звіт";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // comboBoxReportFormat
            // 
            this.comboBoxReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportFormat.Location = new System.Drawing.Point(957, 425);
            this.comboBoxReportFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxReportFormat.Name = "comboBoxReportFormat";
            this.comboBoxReportFormat.Size = new System.Drawing.Size(314, 24);
            this.comboBoxReportFormat.TabIndex = 18;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewVehicles, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtBrand, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtModel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txtYear, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.txtLicensePlate, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.txtDriverID, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtAssignedMaster, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.dtpLastServiceDate, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtLastServiceDetails, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.btnAddVehicle, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnUpdateVehicle, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteVehicle, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxReportFormat, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.comboBoxSortBy, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnSortAscending, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.btnSortDescending, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.btnGenerateReport, 3, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1274, 520);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 520);
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
        private System.Windows.Forms.TextBox txtAssignedMaster;
        private System.Windows.Forms.DateTimePicker dtpLastServiceDate;
        private System.Windows.Forms.TextBox txtLastServiceDetails;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox comboBoxReportFormat;
    }
}

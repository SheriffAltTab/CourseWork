using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar
{
    partial class MastersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMasters;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnAddMaster;
        private System.Windows.Forms.Button btnUpdateMaster;
        private System.Windows.Forms.Button btnDeleteMaster;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReturnToMain;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox comboBoxReportFormat;

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
            this.dataGridViewMasters = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddMaster = new System.Windows.Forms.Button();
            this.btnUpdateMaster = new System.Windows.Forms.Button();
            this.btnDeleteMaster = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxReportFormat = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMasters
            // 
            this.dataGridViewMasters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewMasters, 5);
            this.dataGridViewMasters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMasters.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewMasters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMasters.Name = "dataGridViewMasters";
            this.dataGridViewMasters.RowHeadersWidth = 51;
            this.dataGridViewMasters.RowTemplate.Height = 29;
            this.dataGridViewMasters.Size = new System.Drawing.Size(1061, 318);
            this.dataGridViewMasters.TabIndex = 0;
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
            // txtSpecialty
            // 
            this.txtSpecialty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpecialty.Location = new System.Drawing.Point(642, 324);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(207, 22);
            this.txtSpecialty.TabIndex = 4;
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
            this.dtpHireDate.Location = new System.Drawing.Point(855, 324);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(209, 22);
            this.dtpHireDate.TabIndex = 5;
            // 
            // btnAddMaster
            // 
            this.btnAddMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMaster.Location = new System.Drawing.Point(3, 356);
            this.btnAddMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMaster.Name = "btnAddMaster";
            this.btnAddMaster.Size = new System.Drawing.Size(207, 28);
            this.btnAddMaster.TabIndex = 6;
            this.btnAddMaster.Text = "Додати майстра";
            this.btnAddMaster.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMaster
            // 
            this.btnUpdateMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateMaster.Location = new System.Drawing.Point(216, 356);
            this.btnUpdateMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMaster.Name = "btnUpdateMaster";
            this.btnUpdateMaster.Size = new System.Drawing.Size(207, 28);
            this.btnUpdateMaster.TabIndex = 7;
            this.btnUpdateMaster.Text = "Оновити майстра";
            this.btnUpdateMaster.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMaster
            // 
            this.btnDeleteMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMaster.Location = new System.Drawing.Point(429, 356);
            this.btnDeleteMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMaster.Name = "btnDeleteMaster";
            this.btnDeleteMaster.Size = new System.Drawing.Size(207, 28);
            this.btnDeleteMaster.TabIndex = 8;
            this.btnDeleteMaster.Text = "Видалити майстра";
            this.btnDeleteMaster.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.tableLayoutPanel.SetColumnSpan(this.txtSearch, 2);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(642, 356);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(422, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnToMain.Location = new System.Drawing.Point(855, 420);
            this.btnReturnToMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(209, 28);
            this.btnReturnToMain.TabIndex = 15;
            this.btnReturnToMain.Text = "Назад";
            this.btnReturnToMain.UseVisualStyleBackColor = true;
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
            this.comboBoxSortBy.TabIndex = 11;
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortDescending.Location = new System.Drawing.Point(3, 420);
            this.btnSortDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(207, 28);
            this.btnSortDescending.TabIndex = 12;
            this.btnSortDescending.Text = "Сортувати ↑";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAscending.Location = new System.Drawing.Point(216, 420);
            this.btnSortAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(207, 28);
            this.btnSortAscending.TabIndex = 13;
            this.btnSortAscending.Text = "Сортувати ↓";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewMasters, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtFirstName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dtpBirthDate, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.txtSpecialty, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.dtpHireDate, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAddMaster, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnUpdateMaster, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteMaster, 2, 2);
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
            // comboBoxReportFormat
            // 
            this.comboBoxReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReportFormat.FormattingEnabled = true;
            this.comboBoxReportFormat.Location = new System.Drawing.Point(642, 388);
            this.comboBoxReportFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxReportFormat.Name = "comboBoxReportFormat";
            this.comboBoxReportFormat.Size = new System.Drawing.Size(207, 24);
            this.comboBoxReportFormat.TabIndex = 10;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Location = new System.Drawing.Point(642, 420);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(207, 28);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "Генерувати звіт";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // MastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MastersForm";
            this.Text = "Управління майстрами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

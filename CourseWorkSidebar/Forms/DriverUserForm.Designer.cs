using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar.Forms
{
    partial class DriverUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverUserForm));
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.txtFaultDescription = new System.Windows.Forms.TextBox();
            this.btnReportFault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(10, 40);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(1293, 243);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(12, 325);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.RowHeadersWidth = 51;
            this.dataGridViewVehicles.RowTemplate.Height = 24;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1291, 150);
            this.dataGridViewVehicles.TabIndex = 1;
            // 
            // txtFaultDescription
            // 
            this.txtFaultDescription.Location = new System.Drawing.Point(12, 525);
            this.txtFaultDescription.Multiline = true;
            this.txtFaultDescription.Name = "txtFaultDescription";
            this.txtFaultDescription.Size = new System.Drawing.Size(1291, 60);
            this.txtFaultDescription.TabIndex = 2;
            // 
            // btnReportFault
            // 
            this.btnReportFault.BackColor = System.Drawing.Color.Black;
            this.btnReportFault.FlatAppearance.BorderSize = 0;
            this.btnReportFault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportFault.ForeColor = System.Drawing.Color.White;
            this.btnReportFault.Location = new System.Drawing.Point(10, 591);
            this.btnReportFault.Name = "btnReportFault";
            this.btnReportFault.Size = new System.Drawing.Size(112, 35);
            this.btnReportFault.TabIndex = 3;
            this.btnReportFault.Text = "Повідомити про несправність";
            this.btnReportFault.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Графік роботи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Призначені транспортні засоби";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повідомити про несправність";
            // 
            // DriverUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 626);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReportFault);
            this.Controls.Add(this.txtFaultDescription);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DriverUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.TextBox txtFaultDescription;
        private System.Windows.Forms.Button btnReportFault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

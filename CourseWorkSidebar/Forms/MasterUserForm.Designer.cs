using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar.Forms
{
    partial class MasterUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterUserForm));
            this.dataGridViewAssignedVehicles = new System.Windows.Forms.DataGridView();
            this.dataGridViewReportedFaults = new System.Windows.Forms.DataGridView();
            this.txtResolvedDescription = new System.Windows.Forms.TextBox();
            this.btnMarkAsResolved = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportedFaults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssignedVehicles
            // 
            this.dataGridViewAssignedVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedVehicles.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewAssignedVehicles.Name = "dataGridViewAssignedVehicles";
            this.dataGridViewAssignedVehicles.RowHeadersWidth = 51;
            this.dataGridViewAssignedVehicles.RowTemplate.Height = 24;
            this.dataGridViewAssignedVehicles.Size = new System.Drawing.Size(1284, 150);
            this.dataGridViewAssignedVehicles.TabIndex = 0;
            // 
            // dataGridViewReportedFaults
            // 
            this.dataGridViewReportedFaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportedFaults.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewReportedFaults.Name = "dataGridViewReportedFaults";
            this.dataGridViewReportedFaults.RowHeadersWidth = 51;
            this.dataGridViewReportedFaults.RowTemplate.Height = 24;
            this.dataGridViewReportedFaults.Size = new System.Drawing.Size(1284, 150);
            this.dataGridViewReportedFaults.TabIndex = 1;
            // 
            // txtResolvedDescription
            // 
            this.txtResolvedDescription.Location = new System.Drawing.Point(12, 420);
            this.txtResolvedDescription.Multiline = true;
            this.txtResolvedDescription.Name = "txtResolvedDescription";
            this.txtResolvedDescription.Size = new System.Drawing.Size(1284, 60);
            this.txtResolvedDescription.TabIndex = 2;
            // 
            // btnMarkAsResolved
            // 
            this.btnMarkAsResolved.BackColor = System.Drawing.Color.Black;
            this.btnMarkAsResolved.FlatAppearance.BorderSize = 0;
            this.btnMarkAsResolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsResolved.ForeColor = System.Drawing.Color.White;
            this.btnMarkAsResolved.Location = new System.Drawing.Point(12, 486);
            this.btnMarkAsResolved.Name = "btnMarkAsResolved";
            this.btnMarkAsResolved.Size = new System.Drawing.Size(112, 35);
            this.btnMarkAsResolved.TabIndex = 3;
            this.btnMarkAsResolved.Text = "Виконано";
            this.btnMarkAsResolved.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Призначені автомобілі";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Звіти про несправності";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Опис виконаних робіт";
            // 
            // MasterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarkAsResolved);
            this.Controls.Add(this.txtResolvedDescription);
            this.Controls.Add(this.dataGridViewReportedFaults);
            this.Controls.Add(this.dataGridViewAssignedVehicles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportedFaults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssignedVehicles;
        private System.Windows.Forms.DataGridView dataGridViewReportedFaults;
        private System.Windows.Forms.TextBox txtResolvedDescription;
        private System.Windows.Forms.Button btnMarkAsResolved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

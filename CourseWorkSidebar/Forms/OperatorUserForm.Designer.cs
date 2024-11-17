namespace CourseWorkSidebar.Forms
{
    partial class OperatorUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewDrivers;
        private System.Windows.Forms.DataGridView dataGridViewMasters;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.Button btnAssignVehicle;

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
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.dataGridViewMasters = new System.Windows.Forms.DataGridView();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.btnAssignVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrivers.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewDrivers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.RowHeadersWidth = 51;
            this.dataGridViewDrivers.Size = new System.Drawing.Size(1427, 185);
            this.dataGridViewDrivers.TabIndex = 0;
            // 
            // dataGridViewMasters
            // 
            this.dataGridViewMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasters.Location = new System.Drawing.Point(16, 222);
            this.dataGridViewMasters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMasters.Name = "dataGridViewMasters";
            this.dataGridViewMasters.RowHeadersWidth = 51;
            this.dataGridViewMasters.Size = new System.Drawing.Size(1427, 185);
            this.dataGridViewMasters.TabIndex = 1;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(16, 428);
            this.dataGridViewVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.RowHeadersWidth = 51;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1427, 185);
            this.dataGridViewVehicles.TabIndex = 2;
            // 
            // btnAssignVehicle
            // 
            this.btnAssignVehicle.Location = new System.Drawing.Point(16, 640);
            this.btnAssignVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssignVehicle.Name = "btnAssignVehicle";
            this.btnAssignVehicle.Size = new System.Drawing.Size(160, 37);
            this.btnAssignVehicle.TabIndex = 3;
            this.btnAssignVehicle.Text = "Призначити авто";
            this.btnAssignVehicle.UseVisualStyleBackColor = true;
            // 
            // OperatorUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnAssignVehicle);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Controls.Add(this.dataGridViewMasters);
            this.Controls.Add(this.dataGridViewDrivers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OperatorUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
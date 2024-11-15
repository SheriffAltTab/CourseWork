using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkSidebar
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDrivers = new System.Windows.Forms.Panel();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.pnVehicle = new System.Windows.Forms.Panel();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.PersonnelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPersonnel = new System.Windows.Forms.Panel();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.pnMasters = new System.Windows.Forms.Panel();
            this.btnMasters = new System.Windows.Forms.Button();
            this.pnOperators = new System.Windows.Forms.Panel();
            this.btnOperators = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.personnelTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnSignUp = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDrivers.SuspendLayout();
            this.pnVehicle.SuspendLayout();
            this.PersonnelContainer.SuspendLayout();
            this.pnPersonnel.SuspendLayout();
            this.pnMasters.SuspendLayout();
            this.pnOperators.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnSignUp.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 36);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1069, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таксопарк";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 2);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(32, 32);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click_1);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnDrivers);
            this.sidebar.Controls.Add(this.pnVehicle);
            this.sidebar.Controls.Add(this.PersonnelContainer);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 36);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(90, 857);
            this.sidebar.TabIndex = 1;
            // 
            // pnDrivers
            // 
            this.pnDrivers.Controls.Add(this.btnDrivers);
            this.pnDrivers.Location = new System.Drawing.Point(0, 35);
            this.pnDrivers.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnDrivers.Name = "pnDrivers";
            this.pnDrivers.Size = new System.Drawing.Size(300, 65);
            this.pnDrivers.TabIndex = 3;
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Image = ((System.Drawing.Image)(resources.GetObject("btnDrivers.Image")));
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.Location = new System.Drawing.Point(0, 0);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDrivers.Size = new System.Drawing.Size(300, 65);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.Text = "         Водії";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click_1);
            // 
            // pnVehicle
            // 
            this.pnVehicle.Controls.Add(this.btnVehicles);
            this.pnVehicle.Location = new System.Drawing.Point(0, 105);
            this.pnVehicle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnVehicle.Name = "pnVehicle";
            this.pnVehicle.Size = new System.Drawing.Size(300, 65);
            this.pnVehicle.TabIndex = 4;
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicles.Image")));
            this.btnVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.Location = new System.Drawing.Point(0, 0);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVehicles.Size = new System.Drawing.Size(300, 65);
            this.btnVehicles.TabIndex = 2;
            this.btnVehicles.Text = "         Автотранспорт";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click_1);
            // 
            // PersonnelContainer
            // 
            this.PersonnelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.PersonnelContainer.Controls.Add(this.pnPersonnel);
            this.PersonnelContainer.Controls.Add(this.pnMasters);
            this.PersonnelContainer.Controls.Add(this.pnOperators);
            this.PersonnelContainer.Location = new System.Drawing.Point(0, 175);
            this.PersonnelContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PersonnelContainer.Name = "PersonnelContainer";
            this.PersonnelContainer.Size = new System.Drawing.Size(300, 65);
            this.PersonnelContainer.TabIndex = 2;
            // 
            // pnPersonnel
            // 
            this.pnPersonnel.Controls.Add(this.btnPersonnel);
            this.pnPersonnel.Location = new System.Drawing.Point(0, 0);
            this.pnPersonnel.Margin = new System.Windows.Forms.Padding(0);
            this.pnPersonnel.Name = "pnPersonnel";
            this.pnPersonnel.Size = new System.Drawing.Size(300, 65);
            this.pnPersonnel.TabIndex = 5;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnPersonnel.FlatAppearance.BorderSize = 0;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.Image")));
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(0, 0);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPersonnel.Size = new System.Drawing.Size(300, 65);
            this.btnPersonnel.TabIndex = 2;
            this.btnPersonnel.Text = "         Персонал";
            this.btnPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // pnMasters
            // 
            this.pnMasters.Controls.Add(this.btnMasters);
            this.pnMasters.Location = new System.Drawing.Point(0, 65);
            this.pnMasters.Margin = new System.Windows.Forms.Padding(0);
            this.pnMasters.Name = "pnMasters";
            this.pnMasters.Size = new System.Drawing.Size(300, 65);
            this.pnMasters.TabIndex = 6;
            // 
            // btnMasters
            // 
            this.btnMasters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnMasters.FlatAppearance.BorderSize = 0;
            this.btnMasters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasters.ForeColor = System.Drawing.Color.White;
            this.btnMasters.Image = ((System.Drawing.Image)(resources.GetObject("btnMasters.Image")));
            this.btnMasters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasters.Location = new System.Drawing.Point(0, 0);
            this.btnMasters.Name = "btnMasters";
            this.btnMasters.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMasters.Size = new System.Drawing.Size(300, 65);
            this.btnMasters.TabIndex = 2;
            this.btnMasters.Text = "         Майстри";
            this.btnMasters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasters.UseVisualStyleBackColor = false;
            this.btnMasters.Click += new System.EventHandler(this.btnMasters_Click_1);
            // 
            // pnOperators
            // 
            this.pnOperators.Controls.Add(this.btnOperators);
            this.pnOperators.Location = new System.Drawing.Point(0, 130);
            this.pnOperators.Margin = new System.Windows.Forms.Padding(0);
            this.pnOperators.Name = "pnOperators";
            this.pnOperators.Size = new System.Drawing.Size(300, 65);
            this.pnOperators.TabIndex = 6;
            // 
            // btnOperators
            // 
            this.btnOperators.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnOperators.FlatAppearance.BorderSize = 0;
            this.btnOperators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperators.ForeColor = System.Drawing.Color.White;
            this.btnOperators.Image = ((System.Drawing.Image)(resources.GetObject("btnOperators.Image")));
            this.btnOperators.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperators.Location = new System.Drawing.Point(0, 0);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnOperators.Size = new System.Drawing.Size(300, 65);
            this.btnOperators.TabIndex = 2;
            this.btnOperators.Text = "         Оператори";
            this.btnOperators.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperators.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperators.UseVisualStyleBackColor = false;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click_1);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(0, 245);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(300, 65);
            this.pnLogout.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(300, 65);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "         Вихід з акаунту";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // personnelTransition
            // 
            this.personnelTransition.Interval = 10;
            this.personnelTransition.Tick += new System.EventHandler(this.personnelTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick_1);
            // 
            // pnSignUp
            // 
            this.pnSignUp.Controls.Add(this.btnSignUp);
            this.pnSignUp.Location = new System.Drawing.Point(698, 292);
            this.pnSignUp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnSignUp.Name = "pnSignUp";
            this.pnSignUp.Size = new System.Drawing.Size(215, 65);
            this.pnSignUp.TabIndex = 4;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Black;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Image")));
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.Location = new System.Drawing.Point(0, 0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSignUp.Size = new System.Drawing.Size(215, 65);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "       Зареєструватися";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Location = new System.Drawing.Point(472, 292);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(215, 65);
            this.pnLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(215, 65);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "       Увійти до акаунту";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(472, 262);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(441, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(472, 232);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(441, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1208, 893);
            this.Controls.Add(this.pnSignUp);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDrivers.ResumeLayout(false);
            this.pnVehicle.ResumeLayout(false);
            this.PersonnelContainer.ResumeLayout(false);
            this.pnPersonnel.ResumeLayout(false);
            this.pnMasters.ResumeLayout(false);
            this.pnOperators.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnSignUp.ResumeLayout(false);
            this.pnLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Button btnDrivers;
        private Panel pnDrivers;
        private Panel pnVehicle;
        private Button btnVehicles;
        private Button btnPersonnel;
        private Panel pnPersonnel;
        private Panel pnMasters;
        private Button btnLogout;
        private FlowLayoutPanel PersonnelContainer;
        private Panel pnOperators;
        private Button btnMasters;
        private Panel pnLogout;
        private Button btnOperators;
        private System.Windows.Forms.Timer personnelTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel pnSignUp;
        private Button btnSignUp;
        private Panel pnLogin;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}
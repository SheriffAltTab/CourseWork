using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Forms;
using CourseWorkSidebar.Models;
using static ReaLTaiizor.Controls.ExtendedPanel;

namespace CourseWorkSidebar
{
    public partial class MainForm : Form
    {
        DriversForm drivers;
        VehiclesForm vehicles;
        MastersForm masters;
        OperatorsForm operators;
        DriverUserForm driverUser;
        OperatorUserForm operatorUser;
        MasterUserForm masterUser;

        private readonly UserRepository _userRepository;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            InitializeLogin();
            InitializeRoleSelection();
            mdiProp();
            AddFormMoveFunctionality();
            SetInitialVisibility();
        }

        bool personnelExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            foreach (Control ctrl in Controls)
            {
                if (ctrl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = System.Drawing.Color.FromArgb(232, 234, 237);
                }
            }
        }

        private void InitializeLogin()
        {
            btnLogin.Click += BtnLogIn_Click;
            btnSignUp.Click += BtnSignUp_Click;
            btnLogout.Click += BtnLogout_Click;
            btnReturn.Click += BtnReturn_Click;
            btnLogout.Visible = false;
            SetFormsButtonsVisibility(false);
            SetUserInterfaceVisibility(false);
        }

        private void InitializeRoleSelection()
        {
            btnAdminPanel.Click += BtnAdminPanel_Click;
            btnOperatorPanel.Click += BtnOperatorPanel_Click;
            btnDriverPanel.Click += BtnDriverPanel_Click;
            btnMasterPanel.Click += BtnMasterPanel_Click;
        }

        private void AddFormMoveFunctionality()
        {
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (IsValidLoginInput())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                var currentUser = _userRepository.GetUserByUsername(username);

                if (currentUser != null && _userRepository.AuthenticateUser(username, password))
                {
                    // Перевірка на роль користувача при виборі форми входу
                    if (btnDriverPanel.Focused && currentUser.Role != "Водій")
                    {
                        MessageBox.Show("Цей акаунт не є водієм. Будь ласка, увійдіть як водій.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (btnAdminPanel.Focused && currentUser.Role != "Адміністратор")
                    {
                        MessageBox.Show("Цей акаунт не є адміністратором. Будь ласка, увійдіть як дміністратор.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (btnOperatorPanel.Focused && currentUser.Role != "Оператор")
                    {
                        MessageBox.Show("Цей акаунт не є оператором. Будь ласка, увійдіть як оператор.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (btnMasterPanel.Focused && currentUser.Role != "Майстер")
                    {
                        MessageBox.Show("Цей акаунт не є майстром. Будь ласка, увійдіть як майстер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Вхід успішний!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetUserInterfaceVisibility(true);
                    ClearLoginFields();
                    LoadUserSpecificForm(currentUser);
                }
                else
                {
                    MessageBox.Show("Неправильний логін або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (IsValidLoginInput())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (_userRepository.IsUsernameTaken(username))
                {
                    MessageBox.Show("Користувач із таким логіном вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newUser = new User
                {
                    Username = username,
                    PasswordHash = password,
                    Role = "Адміністратор"
                };
                _userRepository.AddUser(newUser);

                MessageBox.Show("Реєстрація успішна!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearLoginFields();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            SetFormsButtonsVisibility(false);
            SetUserInterfaceVisibility(false);
            SetLoginInterfaceVisibility(false);
            SetRoleSelectionVisibility(true);
            ClearLoginFields();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            SetRoleSelectionVisibility(true);
            SetLoginInterfaceVisibility(false);
        }

        private void SetFormsButtonsVisibility(bool visible)
        {
            btnDrivers.Visible = visible;
            btnVehicles.Visible = visible;
            btnPersonnel.Visible = visible;
            PersonnelContainer.Visible = visible;
        }

        private void SetUserInterfaceVisibility(bool loggedIn)
        {
            btnLogout.Visible = loggedIn;
            sidebar.Enabled = loggedIn;
            SetFormsButtonsVisibility(loggedIn);
            SetLoginInterfaceVisibility(!loggedIn);
        }

        private void SetLoginInterfaceVisibility(bool visible)
        {
            txtUsername.Visible = visible;
            txtPassword.Visible = visible;
            pnLogin.Visible = visible;
            btnLogin.Visible = visible;
            pnSignUp.Visible = visible;
            btnSignUp.Visible = visible;
            btnReturn.Visible = visible;
        }

        private void SetRoleSelectionVisibility(bool visible)
        {
            btnAdminPanel.Visible = visible;
            btnOperatorPanel.Visible = visible;
            btnDriverPanel.Visible = visible;
            btnMasterPanel.Visible = visible;
        }

        private void SetInitialVisibility()
        {
            SetRoleSelectionVisibility(true);
            SetLoginInterfaceVisibility(false);
        }

        private void ClearLoginFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private bool IsValidLoginInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.ForeColor == System.Drawing.Color.Gray)
            {
                MessageBox.Show("Будь ласка, введіть логін.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.ForeColor == System.Drawing.Color.Gray)
            {
                MessageBox.Show("Будь ласка, введіть пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDrivers_Click_1(object sender, EventArgs e)
        {
            if (drivers == null)
            {
                drivers = new DriversForm();
                drivers.FormClosed += Drivers_FormClosed;
                drivers.MdiParent = this;
                drivers.Dock = DockStyle.Fill;
                drivers.Show();
            }
            else
            {
                drivers.Activate();
            }
        }

        private void Drivers_FormClosed(object sender, FormClosedEventArgs e)
        {
            drivers = null;
        }

        private void btnHam_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 90)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;

                    pnDrivers.Width = sidebar.Width;
                    pnVehicle.Width = sidebar.Width;
                    PersonnelContainer.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 300)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;

                    pnDrivers.Width = sidebar.Width;
                    pnVehicle.Width = sidebar.Width;
                    PersonnelContainer.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void personnelTransition_Tick(object sender, EventArgs e)
        {
            if (personnelExpand == false)
            {
                PersonnelContainer.Height += 10;
                if (PersonnelContainer.Height >= 195)
                {
                    personnelTransition.Stop();
                    personnelExpand = true;
                }
            }
            else
            {
                PersonnelContainer.Height -= 10;
                if (PersonnelContainer.Height <= 65)
                {
                    personnelTransition.Stop();
                    personnelExpand = false;
                }
            }
        }

        private void btnVehicles_Click_1(object sender, EventArgs e)
        {
            if (vehicles == null)
            {
                vehicles = new VehiclesForm();
                vehicles.FormClosed += Vehicles_FormClosed;
                vehicles.MdiParent = this;
                vehicles.Dock = DockStyle.Fill;
                vehicles.Show();
            }
            else
            {
                vehicles.Activate();
            }
        }

        private void Vehicles_FormClosed(object sender, FormClosedEventArgs e)
        {
            vehicles = null;
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            personnelTransition.Start();
        }

        private void btnMasters_Click_1(object sender, EventArgs e)
        {
            if (masters == null)
            {
                masters = new MastersForm();
                masters.FormClosed += Masters_FormClosed;
                masters.MdiParent = this;
                masters.Dock = DockStyle.Fill;
                masters.Show();
            }
            else
            {
                masters.Activate();
            }
        }

        private void Masters_FormClosed(object sender, FormClosedEventArgs e)
        {
            masters = null;
        }

        private void btnOperators_Click_1(object sender, EventArgs e)
        {
            if (operators == null)
            {
                operators = new OperatorsForm();
                operators.FormClosed += Operators_FormClosed;
                operators.MdiParent = this;
                operators.Dock = DockStyle.Fill;
                operators.Show();
            }
            else
            {
                operators.Activate();
            }
        }

        private void Operators_FormClosed(object sender, FormClosedEventArgs e)
        {
            operators = null;
        }

        private void BtnAdminPanel_Click(object sender, EventArgs e)
        {
            SetRoleSelectionVisibility(false);
            SetLoginInterfaceVisibility(true);
        }

        private void BtnOperatorPanel_Click(object sender, EventArgs e)
        {
            SetRoleSelectionVisibility(false);
            SetLoginInterfaceVisibility(true);
        }

        private void BtnDriverPanel_Click(object sender, EventArgs e)
        {
            SetRoleSelectionVisibility(false);
            SetLoginInterfaceVisibility(true);
        }

        private void BtnMasterPanel_Click(object sender, EventArgs e)
        {
            SetRoleSelectionVisibility(false);
            SetLoginInterfaceVisibility(true);
        }

        private void LoadUserSpecificForm(User currentUser)
        {
            if (currentUser.Role == "Водій")
            {
                var driverRepository = new DriversRepository();
                var driver = driverRepository.GetDriverById(currentUser.UserID);

                if (driver == null)
                {
                    MessageBox.Show("Водій не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (driverUser == null)
                {
                    driverUser = new DriverUserForm(driver);
                    driverUser.FormClosed += DriverUser_FormClosed;
                    driverUser.MdiParent = this;
                    driverUser.Dock = DockStyle.Fill;
                    driverUser.Show();
                }
                else
                {
                    driverUser.Activate();
                }
            }
            else if (currentUser.Role == "Оператор")
            {
                if (operatorUser == null)
                {
                    operatorUser = new OperatorUserForm();
                    operatorUser.FormClosed += OperatorUser_FormClosed;
                    operatorUser.MdiParent = this;
                    operatorUser.Dock = DockStyle.Fill;
                    operatorUser.Show();
                }
                else
                {
                    operatorUser.Activate();
                }
            }
            else if (currentUser.Role == "Майстер")
            {
                if (masterUser == null)
                {
                    var masterRepository = new MastersRepository();
                    var master = masterRepository.GetMasterById(currentUser.UserID);

                    if (master == null)
                    {
                        MessageBox.Show("Майстер не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    masterUser = new MasterUserForm(master);
                    masterUser.FormClosed += MasterUser_FormClosed;
                    masterUser.MdiParent = this;
                    masterUser.Dock = DockStyle.Fill;
                    masterUser.Show();
                }
                else
                {
                    masterUser.Activate();
                }
            }
            else if (currentUser.Role == "Адміністратор")
            {
                SetFormsButtonsVisibility(true);
            }
        }

        private void DriverUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            driverUser = null;
        }

        private void OperatorUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            operatorUser = null;
        }

        private void MasterUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            masterUser = null;
        }

        private void SetPlaceholderTexts()
        {
            SetPlaceholder(txtUsername, "Логін");
            SetPlaceholder(txtPassword, "Пароль");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder && textBox.ForeColor == Color.Gray)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (textBox == txtPassword)
                    {
                        textBox.PasswordChar = '*';
                    }
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    if (textBox == txtPassword)
                    {
                        textBox.PasswordChar = '\0';
                    }
                }
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetPlaceholderTexts();
        }
    }
}

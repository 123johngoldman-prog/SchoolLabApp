using SchoolLabApp.Helpers;
using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class TechnicianPasswordPanel : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;

        public TechnicianPasswordPanel(UserService userService, RoleService roleService)
        {
            InitializeComponent();

            _userService = userService;
            _roleService = roleService;

            TechnicianPasswordManager.Initialize();
        }

        private void checkBoxTechnicianPasswordPanel_CheckedChanged(object sender, EventArgs e)
        {
            txtTechnicianPasswordPanelPassword.UseSystemPasswordChar =
                !checkBoxTechnicianPasswordPanel.Checked;
        }

        private void btnTechnicianPasswordPanelRegister_Click(object sender, EventArgs e)
        {
            string enteredPassword =
                txtTechnicianPasswordPanelPassword.Text.Trim();

            bool isValid =
                TechnicianPasswordManager.ValidatePassword(enteredPassword);

            if (!isValid)
            {
                MessageBox.Show(
                    "Incorrect technician password.",
                    "Access denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var register = new Register(_userService, _roleService);

            register.ShowDialog();

            this.Close();
        }
    }
}
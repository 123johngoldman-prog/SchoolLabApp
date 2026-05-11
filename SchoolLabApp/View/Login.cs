using SchoolLabApp.Data;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class Login : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly SchoolLabAppDbContext _context;

        public Login(UserService userService, RoleService roleService, SchoolLabAppDbContext context)
        {
            InitializeComponent();
            _userService = userService;
            _roleService = roleService;
            _context     = context;
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
            => txtLoginPassword.UseSystemPasswordChar = !checkBoxLogin.Checked;

        private async void btnLoginLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _userService.Login(
                    txtLoginUsername.Text.Trim(),
                    txtLoginPassword.Text);

                this.Hide();

                string role = user.Role?.Name ?? "";

                if (role == "Student" || role == "Teacher")
                {
                    var loanRepo    = new LoanRepository(_context);
                    var loanService = new LoanService(loanRepo);
                    var assetRepo   = new AssetRepository(_context);
                    var assetService= new AssetService(assetRepo);
                    var panel = new UserLoanPanel(loanService, assetService, user.PersonId ?? 0);
                    panel.ShowDialog();
                }
                else if (role == "Technician")
                {
                    var assetRepo    = new AssetRepository(_context);
                    var assetService = new AssetService(assetRepo);
                    var panel = new TechnicianPanel(assetService);
                    panel.ShowDialog();
                }
                else
                {
                    // Admin or unknown role
                    var assetRepo    = new AssetRepository(_context);
                    var assetService = new AssetService(assetRepo);
                    var panel = new AdminPanel(_userService, _roleService, assetService);
                    panel.ShowDialog();
                }

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            var register = new Register(_userService, _roleService);
            register.ShowDialog();
        }
    }
}

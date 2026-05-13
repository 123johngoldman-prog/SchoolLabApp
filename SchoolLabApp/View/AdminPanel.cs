using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class AdminPanel : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly AssetService _assetService;

        public AdminPanel(UserService userService, RoleService roleService, AssetService assetService)
        {
            InitializeComponent();
            _userService = userService;
            _roleService = roleService;
            _assetService = assetService;
        }

        private async void AdminPanel_Load(object sender, EventArgs e)
            => await LoadUsers();

        private async System.Threading.Tasks.Task LoadUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();
                listBoxAdminPanel.Items.Clear();
                foreach (var u in users)
                    listBoxAdminPanel.Items.Add($"{u.Id} | {u.Username} | {u.Role?.Name ?? "N/A"}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdminPanelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAdminPanelRole.SelectedItem == null)
                    throw new ArgumentException("Please select a role.");

                int roleId = await GetSelectedRoleId();

                var user = new User
                {
                    Username = txtAdminPanelUsername.Text.Trim(),
                    Password = txtAdminPanelPassword.Text,
                    RoleId   = roleId
                };

                await _userService.Register(user);
                MessageBox.Show("User added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAdminPanelEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAdminPanel.SelectedItem == null)
                    throw new ArgumentException("Select a user from the list first.");

                int id = int.Parse(listBoxAdminPanel.SelectedItem.ToString()!.Split('|')[0].Trim());
                int roleId = await GetSelectedRoleId();

                var user = new User
                {
                    Id       = id,
                    Username = txtAdminPanelUsername.Text.Trim(),
                    Password = txtAdminPanelPassword.Text,
                    RoleId   = roleId
                };

                await _userService.UpdateUser(user);
                MessageBox.Show("User updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAdminPanelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAdminPanel.SelectedItem == null)
                    throw new ArgumentException("Select a user from the list first.");

                int id = int.Parse(listBoxAdminPanel.SelectedItem.ToString()!.Split('|')[0].Trim());

                if (MessageBox.Show("Delete this user?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _userService.DeleteUser(id);
                    await LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminPanelTechnicianPanel_Click(object sender, EventArgs e)
        {
            var panel = new TechnicianPanel(_assetService);
            panel.ShowDialog();
        }

        private void btnAdminPanelReportPanel_Click(object sender, EventArgs e)
        {
            var panel = new ReportPanel();
            panel.ShowDialog();
        }

        private async System.Threading.Tasks.Task<int> GetSelectedRoleId()
        {
            if (comboBoxAdminPanelRole.SelectedItem == null)
                throw new ArgumentException("Please select a role.");
            var roles = await _roleService.GetAll();
            string selected = comboBoxAdminPanelRole.SelectedItem.ToString()!;
            foreach (var r in roles)
                if (r.Name == selected) return r.Id;
            throw new InvalidOperationException("Selected role not found in database.");
        }

        private void ClearForm()
        {
            txtAdminPanelUsername.Clear();
            txtAdminPanelPassword.Clear();
            txtAdminPanelEmail.Clear();
            comboBoxAdminPanelRole.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}

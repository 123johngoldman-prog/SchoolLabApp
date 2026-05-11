using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class Register : Form
    {
        private readonly UserService _userService;
        private readonly RoleService _roleService;
        private readonly Dictionary<string, int> _roleMap = new();

        public Register(UserService userService, RoleService roleService)
        {
            InitializeComponent();
            _userService = userService;
            _roleService = roleService;
        }

        private async void Register_Load(object sender, EventArgs e)
        {
            try
            {
                var roles = await _roleService.GetAllAsync();
                comboBoxRegisterRole.Items.Clear();
                _roleMap.Clear();
                foreach (var r in roles)
                {
                    comboBoxRegisterRole.Items.Add(r.Name);
                    _roleMap[r.Name] = r.Id;
                }
                if (comboBoxRegisterRole.Items.Count > 0)
                    comboBoxRegisterRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading roles",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxRegister_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBoxRegister.Checked;
            txtRegisterPassword.UseSystemPasswordChar = !show;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = !show;
        }

        private async void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegisterPassword.Text != txtRegisterPasswordConfirm.Text)
                    throw new ArgumentException("Passwords do not match.");

                if (comboBoxRegisterRole.SelectedItem == null)
                    throw new ArgumentException("Please select a role.");

                if (!_roleMap.TryGetValue(comboBoxRegisterRole.SelectedItem.ToString()!, out int roleId))
                    throw new InvalidOperationException("Selected role not found in database.");

                var user = new User
                {
                    Username = txtRegisterUsername.Text.Trim(),
                    Password = txtRegisterPassword.Text,
                    RoleId   = roleId
                };

                await _userService.Register(user);   

                MessageBox.Show("Registration successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRegister.Checked)
            {
                txtRegisterPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtRegisterPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

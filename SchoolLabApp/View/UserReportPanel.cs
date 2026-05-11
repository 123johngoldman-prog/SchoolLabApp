using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserReportPanel : Form
    {
        public UserReportPanel()
        {
            InitializeComponent();
        }

        private void btnUserReportPanelSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserReportPanelReport.Text))
            {
                MessageBox.Show("Please write a report before sending.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Report sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnUserReportPanelBackToLoans_Click(object sender, EventArgs e)
            => this.Close();

        private void label3_Click(object sender, EventArgs e) { }
    }
}

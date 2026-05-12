using System;
using System.Windows.Forms;
using System.IO;

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
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserReportPanelReport.Text))
                {
                    MessageBox.Show(
                        "Please write a report before sending.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string folderPath = Path.Combine(Application.StartupPath, "Reports");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                string fullPath = Path.Combine(folderPath, fileName);

                string reportText =
                    $"Date: {DateTime.Now}\n" +
                    $"-----------------------------------\n" +
                    txtUserReportPanelReport.Text;

                File.WriteAllText(fullPath, reportText);

                MessageBox.Show(
                    "Report sent successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtUserReportPanelReport.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUserReportPanelBackToLoans_Click(object sender, EventArgs e)
            => this.Close();

        private void label3_Click(object sender, EventArgs e) { }
    }
}

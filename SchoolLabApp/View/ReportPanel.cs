using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class ReportPanel : Form
    {
        public ReportPanel()
        {
            InitializeComponent();
        }

        private void btnReportPanelViewReport_Click(object sender, EventArgs e)
        {
            if (listBoxReportPanel.SelectedItem == null)
            {
                MessageBox.Show("Select a report first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtReportPanelReport.Text = listBoxReportPanel.SelectedItem.ToString();
        }

        private void btnReportPanelDelete_Click(object sender, EventArgs e)
        {
            if (listBoxReportPanel.SelectedItem == null)
            {
                MessageBox.Show("Select a report first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this report?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBoxReportPanel.Items.Remove(listBoxReportPanel.SelectedItem);
                txtReportPanelReport.Clear();
            }
        }
    }
}

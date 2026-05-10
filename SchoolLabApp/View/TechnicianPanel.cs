using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class TechnicianPanel : Form
    {
        private readonly AssetService _assetService;
        public TechnicianPanel(AssetService assetService)
        {
            InitializeComponent();
            _assetService = assetService;
        }

        private async void btnTechnicianPanelAdd_Click(object sender, EventArgs e)
        {
            int categoryId = (int)comboBoxTechnicianPanelCategory.SelectedValue;

            string status = string.Empty;

            if (radioButtonTechnicianPanelStatusAvelible.Checked)
            {
                status = radioButtonTechnicianPanelStatusAvelible.Text;
            }
            else if (radioButtonTechnicianPanelStatusUnavelible.Checked)
            {
                status = radioButtonTechnicianPanelStatusUnavelible.Text;
            }
            else if (radioButtonTechnicianPanelStatusBroken.Checked)
            {
                status = radioButtonTechnicianPanelStatusBroken.Text;
            }

            await _assetService.AddAssets(txtTechnicianPanelName.Text,
                                    status,
                                    categoryId);

            MessageBox.Show("Asset added successfully !");
        }

        private async void btnTechnicianPanelDelete_Click(object sender, EventArgs e)
        {
            int id = listBoxTechnicianPanel.SelectedIndex;

            await _assetService.DeleteAsset(id);
        }

        private void btnTechnicianPanelReportPanel_Click(object sender, EventArgs e)
        {
            var reportPanel = new ReportPanel();
            reportPanel.ShowDialog();
        }

        private void btnTechnicianPanelEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            int categoryId = comboBoxTechnicianPanelCategory.SelectedIndex;

            await _assetService.AddAssets(txtTechnicianPanelName.Text,
                                    comboBoxTechnicianPanelCategory.Text,
                                    categoryId);

            MessageBox.Show("Asset added successfully !");
        }

        private async Task btnTechnicianPanelDelete_Click(object sender, EventArgs e)
        {
        }
    }
}

using SchoolLabApp.Services;
using System;
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

        private async void TechnicianPanel_Load(object sender, EventArgs e)
            => await LoadAssets();

        private async System.Threading.Tasks.Task LoadAssets()
        {
            try
            {
                var assets = await _assetService.GetAll();
                listBoxTechnicianPanel.Items.Clear();
                foreach (var a in assets)
                    listBoxTechnicianPanel.Items.Add($"{a.Id} | {a.Name} | {a.Status} | {a.Category?.Name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTechnicianPanelAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTechnicianPanelCategory.SelectedItem == null)
                    throw new ArgumentException("Please select a category.");

                string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                              : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                              : "Broken";

                await _assetService.AddAssets(
                    txtTechnicianPanelName.Text.Trim(),
                    status,
                    comboBoxTechnicianPanelCategory.SelectedIndex + 1);

                MessageBox.Show("Asset added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadAssets();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnTechnicianPanelEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTechnicianPanel.SelectedItem == null)
                    throw new ArgumentException("Select an asset from the list first.");

                int id = int.Parse(listBoxTechnicianPanel.SelectedItem.ToString()!.Split('|')[0].Trim());
                string status = radioButtonTechnicianPanelStatusAvelible.Checked ? "Available"
                              : radioButtonTechnicianPanelStatusUnavelible.Checked ? "Unavailable"
                              : "Broken";

                var asset = new Models.Asset
                {
                    Id         = id,
                    Name       = txtTechnicianPanelName.Text.Trim(),
                    Status     = status,
                    CategoryId = comboBoxTechnicianPanelCategory.SelectedIndex + 1,
                };

                await _assetService.UpdateAsset(asset);
                MessageBox.Show("Asset updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadAssets();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnTechnicianPanelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTechnicianPanel.SelectedItem == null)
                    throw new ArgumentException("Select an asset from the list first.");

                int id = int.Parse(listBoxTechnicianPanel.SelectedItem.ToString()!.Split('|')[0].Trim());

                if (MessageBox.Show("Delete this asset?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _assetService.DeleteAsset(id);
                    await LoadAssets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTechnicianPanelReportPanel_Click(object sender, EventArgs e)
        {
            var panel = new ReportPanel();
            panel.ShowDialog();
        }

        private void ClearForm()
        {
            txtTechnicianPanelName.Clear();
            txtTechnicianPanelDescription.Clear();
            comboBoxTechnicianPanelCategory.SelectedIndex = -1;
            radioButtonTechnicianPanelStatusAvelible.Checked = false;
            radioButtonTechnicianPanelStatusUnavelible.Checked = false;
            radioButtonTechnicianPanelStatusBroken.Checked = false;
        }
    }
}

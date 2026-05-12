using SchoolLabApp.Models;
using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserLoanPanel : Form
    {
        private readonly LoanService _loanService;
        private readonly AssetService _assetService;
        private readonly int _personId;

        public UserLoanPanel(LoanService loanService, AssetService assetService, int personId)
        {
            InitializeComponent();
            _loanService  = loanService;
            _assetService = assetService;
            _personId     = personId;
        }

        private async void UserLoanPanel_Load(object sender, EventArgs e)
        {
            await LoadAssets();
        }

        private async Task LoadAssets()
        {
            try
            {
                int categoryId = comboBoxUserLoanPanelCategory.SelectedIndex + 1;
                IEnumerable<Asset> assets;

                if (categoryId > 0)
                {
                    assets = await _assetService.GetByCategory(categoryId);
                }
                else
                {
                    assets = await _assetService.GetAll();
                }

                listBoxUserLoanPanel.Items.Clear();
                foreach (var a in assets)
                {
                    listBoxUserLoanPanel.Items.Add($"{a.Id} | {a.Name} | {a.Status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUserLoanPanelTake_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUserLoanPanel.SelectedItem == null)
                {
                    throw new ArgumentException("Select an asset first.");
                }
                if (!int.TryParse(txtUserLoanPanelDuration.Text, out int days) || days <= 0)
                {
                    throw new ArgumentException("Enter a valid duration in days.");
                }

                int assetId = int.Parse(listBoxUserLoanPanel.SelectedItem.ToString()!.Split('|')[0].Trim());
                MessageBox.Show($"AssetId: {assetId}, PersonId: {_personId}");

                await _loanService.AddLoan(assetId, _personId, int.Parse(txtUserLoanPanelDuration.Text), "Unavelible");

                MessageBox.Show("Asset loaned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadAssets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUserLoanPanelReturn_Click(object sender, EventArgs e)
        {
            var returnPanel = new UserReturnPanel(_loanService, _personId);
            returnPanel.ShowDialog();
        }

        private void btnUserLoanPanelReport_Click(object sender, EventArgs e)
        {
            var reportPanel = new UserReportPanel();
            reportPanel.ShowDialog();
        }

        private async void comboBoxUserLoanPanelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadAssets();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
    }
}

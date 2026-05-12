using SchoolLabApp.Services;
using System;
using System.Windows.Forms;

namespace SchoolLabApp.View
{
    public partial class UserReturnPanel : Form
    {
        private readonly LoanService _loanService;
        private readonly int _personId;

        public UserReturnPanel(LoanService loanService, int personId)
        {
            InitializeComponent();
            _loanService = loanService;
            _personId    = personId;
        }

        private async void UserReturnPanel_Load(object sender, EventArgs e)
        {
            try
            {
                var loans = await _loanService.GetLoansByPerson(_personId);
                listBoxUserReturnPanel.Items.Clear();
                foreach (var l in loans)
                {
                    listBoxUserReturnPanel.Items.Add($"{l.Id} | {l.Asset?.Name} | {l.Status} | Started: {l.StartDate:d}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUserReturnePanelReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUserReturnPanel.SelectedItem == null)
                {
                    throw new ArgumentException("Select a loan to return.");
                }

                int loanId = int.Parse(listBoxUserReturnPanel.SelectedItem.ToString()!.Split('|')[0].Trim());
                await _loanService.ReturnLoan(loanId);
                MessageBox.Show("Asset returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUserReturnePanelBackToLoans_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}

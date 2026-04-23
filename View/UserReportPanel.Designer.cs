namespace SchoolLabApp.View
{
    partial class UserReportPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserReportPanelReport = new TextBox();
            btnUserReportPanelBackToLoans = new Button();
            btnUserReportPanelSend = new Button();
            SuspendLayout();
            // 
            // txtUserReportPanelReport
            // 
            txtUserReportPanelReport.Location = new Point(12, 12);
            txtUserReportPanelReport.Multiline = true;
            txtUserReportPanelReport.Name = "txtUserReportPanelReport";
            txtUserReportPanelReport.Size = new Size(481, 203);
            txtUserReportPanelReport.TabIndex = 0;
            // 
            // btnUserReportPanelBackToLoans
            // 
            btnUserReportPanelBackToLoans.BackColor = SystemColors.Control;
            btnUserReportPanelBackToLoans.FlatStyle = FlatStyle.Popup;
            btnUserReportPanelBackToLoans.Location = new Point(381, 247);
            btnUserReportPanelBackToLoans.Name = "btnUserReportPanelBackToLoans";
            btnUserReportPanelBackToLoans.Size = new Size(112, 28);
            btnUserReportPanelBackToLoans.TabIndex = 31;
            btnUserReportPanelBackToLoans.Text = "Back to loans";
            btnUserReportPanelBackToLoans.UseVisualStyleBackColor = false;
            // 
            // btnUserReportPanelSend
            // 
            btnUserReportPanelSend.BackColor = SystemColors.Control;
            btnUserReportPanelSend.FlatStyle = FlatStyle.Popup;
            btnUserReportPanelSend.Location = new Point(12, 247);
            btnUserReportPanelSend.Name = "btnUserReportPanelSend";
            btnUserReportPanelSend.Size = new Size(112, 28);
            btnUserReportPanelSend.TabIndex = 32;
            btnUserReportPanelSend.Text = "Send";
            btnUserReportPanelSend.UseVisualStyleBackColor = false;
            // 
            // UserReportPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(505, 298);
            Controls.Add(btnUserReportPanelSend);
            Controls.Add(btnUserReportPanelBackToLoans);
            Controls.Add(txtUserReportPanelReport);
            Name = "UserReportPanel";
            Text = "UserReportPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserReportPanelReport;
        private Button btnUserReportPanelBackToLoans;
        private Button btnUserReportPanelSend;
    }
}
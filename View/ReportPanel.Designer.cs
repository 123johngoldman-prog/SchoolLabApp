namespace SchoolLabApp.View
{
    partial class ReportPanel
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
            listBoxReportPanel = new ListBox();
            txtReportPanelReport = new TextBox();
            btnReportPanelViewReport = new Button();
            btnReportPanelDelete = new Button();
            SuspendLayout();
            // 
            // listBoxReportPanel
            // 
            listBoxReportPanel.ForeColor = SystemColors.MenuBar;
            listBoxReportPanel.FormattingEnabled = true;
            listBoxReportPanel.Location = new Point(12, 12);
            listBoxReportPanel.Name = "listBoxReportPanel";
            listBoxReportPanel.Size = new Size(352, 244);
            listBoxReportPanel.TabIndex = 0;
            // 
            // txtReportPanelReport
            // 
            txtReportPanelReport.Location = new Point(418, 12);
            txtReportPanelReport.Multiline = true;
            txtReportPanelReport.Name = "txtReportPanelReport";
            txtReportPanelReport.Size = new Size(344, 304);
            txtReportPanelReport.TabIndex = 1;
            // 
            // btnReportPanelViewReport
            // 
            btnReportPanelViewReport.BackColor = Color.White;
            btnReportPanelViewReport.FlatAppearance.BorderColor = Color.Black;
            btnReportPanelViewReport.FlatAppearance.BorderSize = 4;
            btnReportPanelViewReport.FlatStyle = FlatStyle.Popup;
            btnReportPanelViewReport.ForeColor = SystemColors.ActiveCaptionText;
            btnReportPanelViewReport.Location = new Point(26, 277);
            btnReportPanelViewReport.Name = "btnReportPanelViewReport";
            btnReportPanelViewReport.Size = new Size(112, 28);
            btnReportPanelViewReport.TabIndex = 33;
            btnReportPanelViewReport.Text = "View report";
            btnReportPanelViewReport.UseVisualStyleBackColor = false;
            // 
            // btnReportPanelDelete
            // 
            btnReportPanelDelete.BackColor = Color.OrangeRed;
            btnReportPanelDelete.FlatStyle = FlatStyle.Popup;
            btnReportPanelDelete.Location = new Point(231, 277);
            btnReportPanelDelete.Name = "btnReportPanelDelete";
            btnReportPanelDelete.Size = new Size(112, 28);
            btnReportPanelDelete.TabIndex = 36;
            btnReportPanelDelete.Text = "Delete";
            btnReportPanelDelete.UseVisualStyleBackColor = false;
            // 
            // ReportPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(777, 330);
            Controls.Add(btnReportPanelDelete);
            Controls.Add(btnReportPanelViewReport);
            Controls.Add(txtReportPanelReport);
            Controls.Add(listBoxReportPanel);
            Name = "ReportPanel";
            Text = "ReportPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReportPanel;
        private TextBox txtReportPanelReport;
        private Button btnReportPanelViewReport;
        private Button btnReportPanelDelete;
    }
}
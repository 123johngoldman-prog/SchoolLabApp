namespace SchoolLabApp.View
{
    partial class UserReturnPanel
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
            btnUserReturnePanelBackToLoans = new Button();
            btnUserReturnePanelReturn = new Button();
            listBoxUserReturnPanel = new ListBox();
            SuspendLayout();
            // 
            // btnUserReturnePanelBackToLoans
            // 
            btnUserReturnePanelBackToLoans.BackColor = SystemColors.Control;
            btnUserReturnePanelBackToLoans.FlatStyle = FlatStyle.Popup;
            btnUserReturnePanelBackToLoans.Location = new Point(39, 220);
            btnUserReturnePanelBackToLoans.Name = "btnUserReturnePanelBackToLoans";
            btnUserReturnePanelBackToLoans.Size = new Size(112, 28);
            btnUserReturnePanelBackToLoans.TabIndex = 30;
            btnUserReturnePanelBackToLoans.Text = "Back to loans";
            btnUserReturnePanelBackToLoans.UseVisualStyleBackColor = false;
            // 
            // btnUserReturnePanelReturn
            // 
            btnUserReturnePanelReturn.BackColor = SystemColors.Control;
            btnUserReturnePanelReturn.FlatStyle = FlatStyle.Popup;
            btnUserReturnePanelReturn.Location = new Point(39, 51);
            btnUserReturnePanelReturn.Name = "btnUserReturnePanelReturn";
            btnUserReturnePanelReturn.Size = new Size(112, 28);
            btnUserReturnePanelReturn.TabIndex = 31;
            btnUserReturnePanelReturn.Text = "Return";
            btnUserReturnePanelReturn.UseVisualStyleBackColor = false;
            // 
            // listBoxUserReturnPanel
            // 
            listBoxUserReturnPanel.ForeColor = SystemColors.MenuBar;
            listBoxUserReturnPanel.FormattingEnabled = true;
            listBoxUserReturnPanel.Location = new Point(208, 22);
            listBoxUserReturnPanel.Name = "listBoxUserReturnPanel";
            listBoxUserReturnPanel.Size = new Size(543, 259);
            listBoxUserReturnPanel.TabIndex = 32;
            // 
            // UserReturnPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(778, 303);
            Controls.Add(listBoxUserReturnPanel);
            Controls.Add(btnUserReturnePanelReturn);
            Controls.Add(btnUserReturnePanelBackToLoans);
            Name = "UserReturnPanel";
            Text = "UserReturnPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUserReturnePanelBackToLoans;
        private Button btnUserReturnePanelReturn;
        private ListBox listBoxUserReturnPanel;
    }
}
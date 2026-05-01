namespace SchoolLabApp.View
{
    partial class UserLoanPanel
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
            comboBoxUserLoanPanelCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            listBoxUserLoanPanel = new ListBox();
            btnUserLoanPanelReport = new Button();
            txtUserLoanPanelDuration = new TextBox();
            btnUserLoanPanelTake = new Button();
            btnUserLoanPanelReturn = new Button();
            SuspendLayout();
            // 
            // comboBoxUserLoanPanelCategory
            // 
            comboBoxUserLoanPanelCategory.FormattingEnabled = true;
            comboBoxUserLoanPanelCategory.Items.AddRange(new object[] { "Computers", "Lab equipment", "Books" });
            comboBoxUserLoanPanelCategory.Location = new Point(26, 55);
            comboBoxUserLoanPanelCategory.Name = "comboBoxUserLoanPanelCategory";
            comboBoxUserLoanPanelCategory.Size = new Size(199, 23);
            comboBoxUserLoanPanelCategory.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 25;
            label2.Text = "Duration (in days)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 24;
            label1.Text = "Category";
            // 
            // listBoxUserLoanPanel
            // 
            listBoxUserLoanPanel.ForeColor = SystemColors.MenuBar;
            listBoxUserLoanPanel.FormattingEnabled = true;
            listBoxUserLoanPanel.Location = new Point(272, 26);
            listBoxUserLoanPanel.Name = "listBoxUserLoanPanel";
            listBoxUserLoanPanel.Size = new Size(502, 394);
            listBoxUserLoanPanel.TabIndex = 20;
            // 
            // btnUserLoanPanelReport
            // 
            btnUserLoanPanelReport.BackColor = Color.Tomato;
            btnUserLoanPanelReport.FlatAppearance.BorderColor = Color.Tomato;
            btnUserLoanPanelReport.FlatStyle = FlatStyle.Popup;
            btnUserLoanPanelReport.Location = new Point(63, 392);
            btnUserLoanPanelReport.Name = "btnUserLoanPanelReport";
            btnUserLoanPanelReport.Size = new Size(112, 28);
            btnUserLoanPanelReport.TabIndex = 19;
            btnUserLoanPanelReport.Text = "Report";
            btnUserLoanPanelReport.UseVisualStyleBackColor = false;
            // 
            // txtUserLoanPanelDuration
            // 
            txtUserLoanPanelDuration.Location = new Point(26, 120);
            txtUserLoanPanelDuration.Name = "txtUserLoanPanelDuration";
            txtUserLoanPanelDuration.Size = new Size(199, 23);
            txtUserLoanPanelDuration.TabIndex = 16;
            // 
            // btnUserLoanPanelTake
            // 
            btnUserLoanPanelTake.BackColor = SystemColors.Control;
            btnUserLoanPanelTake.FlatStyle = FlatStyle.Popup;
            btnUserLoanPanelTake.Location = new Point(63, 173);
            btnUserLoanPanelTake.Name = "btnUserLoanPanelTake";
            btnUserLoanPanelTake.Size = new Size(112, 28);
            btnUserLoanPanelTake.TabIndex = 29;
            btnUserLoanPanelTake.Text = "Take";
            btnUserLoanPanelTake.UseVisualStyleBackColor = false;
            // 
            // btnUserLoanPanelReturn
            // 
            btnUserLoanPanelReturn.BackColor = SystemColors.Control;
            btnUserLoanPanelReturn.FlatStyle = FlatStyle.Popup;
            btnUserLoanPanelReturn.Location = new Point(63, 225);
            btnUserLoanPanelReturn.Name = "btnUserLoanPanelReturn";
            btnUserLoanPanelReturn.Size = new Size(112, 28);
            btnUserLoanPanelReturn.TabIndex = 30;
            btnUserLoanPanelReturn.Text = "Return";
            btnUserLoanPanelReturn.UseVisualStyleBackColor = false;
            // 
            // UserLoanPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUserLoanPanelReturn);
            Controls.Add(btnUserLoanPanelTake);
            Controls.Add(comboBoxUserLoanPanelCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxUserLoanPanel);
            Controls.Add(btnUserLoanPanelReport);
            Controls.Add(txtUserLoanPanelDuration);
            Name = "UserLoanPanel";
            Text = "UserLoanPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserLoanPanelCategory;
        private Label label2;
        private Label label1;
        private ListBox listBoxUserLoanPanel;
        private Button btnUserLoanPanelReport;
        private TextBox txtUserLoanPanelDuration;
        private Button btnUserLoanPanelTake;
        private Button btnUserLoanPanelReturn;
    }
}
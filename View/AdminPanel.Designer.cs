namespace SchoolLabApp.View
{
    partial class AdminPanel
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
            comboBoxAdminPanelRole = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdminPanelDelete = new Button();
            btnAdminPanelEdit = new Button();
            btnAdminPanelAdd = new Button();
            listBoxAdminPanel = new ListBox();
            btnAdminPanelReportPanel = new Button();
            btnAdminPanelTechnicianPanel = new Button();
            txtAdminPanelPassword = new TextBox();
            txtAdminPanelEmail = new TextBox();
            txtAdminPanelUsername = new TextBox();
            SuspendLayout();
            // 
            // comboBoxAdminPanelRole
            // 
            comboBoxAdminPanelRole.FormattingEnabled = true;
            comboBoxAdminPanelRole.Items.AddRange(new object[] { "Student", "Teacher", "Technician" });
            comboBoxAdminPanelRole.Location = new Point(26, 244);
            comboBoxAdminPanelRole.Name = "comboBoxAdminPanelRole";
            comboBoxAdminPanelRole.Size = new Size(199, 23);
            comboBoxAdminPanelRole.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 226);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 27;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 163);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 26;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 25;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 24;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // btnAdminPanelDelete
            // 
            btnAdminPanelDelete.BackColor = Color.OrangeRed;
            btnAdminPanelDelete.FlatStyle = FlatStyle.Popup;
            btnAdminPanelDelete.Location = new Point(640, 396);
            btnAdminPanelDelete.Name = "btnAdminPanelDelete";
            btnAdminPanelDelete.Size = new Size(112, 28);
            btnAdminPanelDelete.TabIndex = 23;
            btnAdminPanelDelete.Text = "Delete";
            btnAdminPanelDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdminPanelEdit
            // 
            btnAdminPanelEdit.BackColor = Color.Aquamarine;
            btnAdminPanelEdit.FlatStyle = FlatStyle.Popup;
            btnAdminPanelEdit.Location = new Point(466, 396);
            btnAdminPanelEdit.Name = "btnAdminPanelEdit";
            btnAdminPanelEdit.Size = new Size(112, 28);
            btnAdminPanelEdit.TabIndex = 22;
            btnAdminPanelEdit.Text = "Edit";
            btnAdminPanelEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdminPanelAdd
            // 
            btnAdminPanelAdd.BackColor = Color.YellowGreen;
            btnAdminPanelAdd.FlatStyle = FlatStyle.Popup;
            btnAdminPanelAdd.Location = new Point(294, 396);
            btnAdminPanelAdd.Name = "btnAdminPanelAdd";
            btnAdminPanelAdd.Size = new Size(112, 28);
            btnAdminPanelAdd.TabIndex = 21;
            btnAdminPanelAdd.Text = "Add";
            btnAdminPanelAdd.UseVisualStyleBackColor = false;
            // 
            // listBoxAdminPanel
            // 
            listBoxAdminPanel.ForeColor = SystemColors.ControlLightLight;
            listBoxAdminPanel.FormattingEnabled = true;
            listBoxAdminPanel.Location = new Point(272, 26);
            listBoxAdminPanel.Name = "listBoxAdminPanel";
            listBoxAdminPanel.Size = new Size(502, 349);
            listBoxAdminPanel.TabIndex = 20;
            // 
            // btnAdminPanelReportPanel
            // 
            btnAdminPanelReportPanel.BackColor = Color.White;
            btnAdminPanelReportPanel.FlatAppearance.BorderColor = Color.Black;
            btnAdminPanelReportPanel.FlatAppearance.BorderSize = 4;
            btnAdminPanelReportPanel.FlatStyle = FlatStyle.Popup;
            btnAdminPanelReportPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminPanelReportPanel.Location = new Point(72, 396);
            btnAdminPanelReportPanel.Name = "btnAdminPanelReportPanel";
            btnAdminPanelReportPanel.Size = new Size(112, 28);
            btnAdminPanelReportPanel.TabIndex = 19;
            btnAdminPanelReportPanel.Text = "Report Panel";
            btnAdminPanelReportPanel.UseVisualStyleBackColor = false;
            // 
            // btnAdminPanelTechnicianPanel
            // 
            btnAdminPanelTechnicianPanel.BackColor = SystemColors.HighlightText;
            btnAdminPanelTechnicianPanel.FlatStyle = FlatStyle.Popup;
            btnAdminPanelTechnicianPanel.Location = new Point(72, 347);
            btnAdminPanelTechnicianPanel.Name = "btnAdminPanelTechnicianPanel";
            btnAdminPanelTechnicianPanel.Size = new Size(112, 28);
            btnAdminPanelTechnicianPanel.TabIndex = 18;
            btnAdminPanelTechnicianPanel.Text = "Technician Panel";
            btnAdminPanelTechnicianPanel.UseVisualStyleBackColor = false;
            // 
            // txtAdminPanelPassword
            // 
            txtAdminPanelPassword.Location = new Point(26, 181);
            txtAdminPanelPassword.Name = "txtAdminPanelPassword";
            txtAdminPanelPassword.Size = new Size(199, 23);
            txtAdminPanelPassword.TabIndex = 17;
            // 
            // txtAdminPanelEmail
            // 
            txtAdminPanelEmail.Location = new Point(26, 120);
            txtAdminPanelEmail.Name = "txtAdminPanelEmail";
            txtAdminPanelEmail.Size = new Size(199, 23);
            txtAdminPanelEmail.TabIndex = 16;
            // 
            // txtAdminPanelUsername
            // 
            txtAdminPanelUsername.Location = new Point(26, 55);
            txtAdminPanelUsername.Name = "txtAdminPanelUsername";
            txtAdminPanelUsername.Size = new Size(199, 23);
            txtAdminPanelUsername.TabIndex = 15;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxAdminPanelRole);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdminPanelDelete);
            Controls.Add(btnAdminPanelEdit);
            Controls.Add(btnAdminPanelAdd);
            Controls.Add(listBoxAdminPanel);
            Controls.Add(btnAdminPanelReportPanel);
            Controls.Add(btnAdminPanelTechnicianPanel);
            Controls.Add(txtAdminPanelPassword);
            Controls.Add(txtAdminPanelEmail);
            Controls.Add(txtAdminPanelUsername);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAdminPanelRole;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdminPanelDelete;
        private Button btnAdminPanelEdit;
        private Button btnAdminPanelAdd;
        private ListBox listBoxAdminPanel;
        private Button btnAdminPanelReportPanel;
        private Button btnAdminPanelTechnicianPanel;
        private TextBox txtAdminPanelPassword;
        private TextBox txtAdminPanelEmail;
        private TextBox txtAdminPanelUsername;
    }
}
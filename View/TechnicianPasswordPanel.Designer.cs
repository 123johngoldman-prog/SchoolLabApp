namespace SchoolLabApp.View
{
    partial class TechnicianPasswordPanel
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
            txtTechnicianPasswordPanelPassword = new TextBox();
            btnTechnicianPasswordPanelRegister = new Button();
            checkBoxTechnicianPasswordPanel = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTechnicianPasswordPanelPassword
            // 
            txtTechnicianPasswordPanelPassword.Location = new Point(22, 46);
            txtTechnicianPasswordPanelPassword.Name = "txtTechnicianPasswordPanelPassword";
            txtTechnicianPasswordPanelPassword.Size = new Size(220, 23);
            txtTechnicianPasswordPanelPassword.TabIndex = 16;
            // 
            // btnTechnicianPasswordPanelRegister
            // 
            btnTechnicianPasswordPanelRegister.BackColor = Color.White;
            btnTechnicianPasswordPanelRegister.FlatAppearance.BorderColor = Color.Black;
            btnTechnicianPasswordPanelRegister.FlatAppearance.BorderSize = 4;
            btnTechnicianPasswordPanelRegister.FlatStyle = FlatStyle.Popup;
            btnTechnicianPasswordPanelRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnTechnicianPasswordPanelRegister.Location = new Point(79, 124);
            btnTechnicianPasswordPanelRegister.Name = "btnTechnicianPasswordPanelRegister";
            btnTechnicianPasswordPanelRegister.Size = new Size(112, 28);
            btnTechnicianPasswordPanelRegister.TabIndex = 33;
            btnTechnicianPasswordPanelRegister.Text = "Register";
            btnTechnicianPasswordPanelRegister.UseVisualStyleBackColor = false;
            // 
            // checkBoxTechnicianPasswordPanel
            // 
            checkBoxTechnicianPasswordPanel.AutoSize = true;
            checkBoxTechnicianPasswordPanel.Location = new Point(216, 84);
            checkBoxTechnicianPasswordPanel.Name = "checkBoxTechnicianPasswordPanel";
            checkBoxTechnicianPasswordPanel.Size = new Size(15, 14);
            checkBoxTechnicianPasswordPanel.TabIndex = 34;
            checkBoxTechnicianPasswordPanel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 35;
            label1.Text = "Technician password (contact an admin)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 84);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 36;
            label2.Text = "Show password";
            // 
            // TechnicianPasswordPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(278, 180);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxTechnicianPasswordPanel);
            Controls.Add(btnTechnicianPasswordPanelRegister);
            Controls.Add(txtTechnicianPasswordPanelPassword);
            Name = "TechnicianPasswordPanel";
            Text = "TechnicianPasswordPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTechnicianPasswordPanelPassword;
        private Button btnTechnicianPasswordPanelRegister;
        private CheckBox checkBoxTechnicianPasswordPanel;
        private Label label1;
        private Label label2;
    }
}
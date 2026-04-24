namespace SchoolLabApp.View
{
    partial class Register
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
            label1 = new Label();
            checkBoxRegister = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtRegisterPasswordConfirm = new TextBox();
            txtRegisterPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtRegisterEmail = new TextBox();
            txtRegisterUsername = new TextBox();
            comboBoxRegisterRole = new ComboBox();
            label4 = new Label();
            btnRegisterRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 393);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 44;
            label1.Text = "Show password";
            // 
            // checkBoxRegister
            // 
            checkBoxRegister.AutoSize = true;
            checkBoxRegister.Location = new Point(254, 393);
            checkBoxRegister.Name = "checkBoxRegister";
            checkBoxRegister.Size = new Size(15, 14);
            checkBoxRegister.TabIndex = 43;
            checkBoxRegister.UseVisualStyleBackColor = true;
            checkBoxRegister.CheckedChanged += checkBoxRegister_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 336);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 42;
            label3.Text = "Confirm password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 275);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 41;
            label2.Text = "Password";
            // 
            // txtRegisterPasswordConfirm
            // 
            txtRegisterPasswordConfirm.Location = new Point(77, 354);
            txtRegisterPasswordConfirm.Name = "txtRegisterPasswordConfirm";
            txtRegisterPasswordConfirm.Size = new Size(199, 23);
            txtRegisterPasswordConfirm.TabIndex = 40;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(77, 293);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(199, 23);
            txtRegisterPassword.TabIndex = 39;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 214);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 48;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 153);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 47;
            label6.Text = "Username";
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(77, 232);
            txtRegisterEmail.Multiline = true;
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(199, 23);
            txtRegisterEmail.TabIndex = 46;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(77, 171);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(199, 23);
            txtRegisterUsername.TabIndex = 45;
            // 
            // comboBoxRegisterRole
            // 
            comboBoxRegisterRole.FormattingEnabled = true;
            comboBoxRegisterRole.Items.AddRange(new object[] { "Student", "Teacher", "Technician" });
            comboBoxRegisterRole.Location = new Point(77, 430);
            comboBoxRegisterRole.Name = "comboBoxRegisterRole";
            comboBoxRegisterRole.Size = new Size(199, 23);
            comboBoxRegisterRole.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 412);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 49;
            label4.Text = "Role";
            // 
            // btnRegisterRegister
            // 
            btnRegisterRegister.BackColor = Color.White;
            btnRegisterRegister.FlatAppearance.BorderColor = Color.Black;
            btnRegisterRegister.FlatAppearance.BorderSize = 4;
            btnRegisterRegister.FlatStyle = FlatStyle.Popup;
            btnRegisterRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnRegisterRegister.Location = new Point(141, 508);
            btnRegisterRegister.Name = "btnRegisterRegister";
            btnRegisterRegister.Size = new Size(81, 28);
            btnRegisterRegister.TabIndex = 51;
            btnRegisterRegister.Text = "Register";
            btnRegisterRegister.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(360, 570);
            Controls.Add(btnRegisterRegister);
            Controls.Add(comboBoxRegisterRole);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtRegisterEmail);
            Controls.Add(txtRegisterUsername);
            Controls.Add(label1);
            Controls.Add(checkBoxRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRegisterPasswordConfirm);
            Controls.Add(txtRegisterPassword);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBoxRegister;
        private Label label3;
        private Label label2;
        private TextBox txtRegisterPasswordConfirm;
        private TextBox txtRegisterPassword;
        private Label label5;
        private Label label6;
        private TextBox txtRegisterEmail;
        private TextBox txtRegisterUsername;
        private ComboBox comboBoxRegisterRole;
        private Label label4;
        private Button btnRegisterRegister;
    }
}
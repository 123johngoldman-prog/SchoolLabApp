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
            label6 = new Label();
            txtRegisterUsername = new TextBox();
            comboBoxRegisterRole = new ComboBox();
            label4 = new Label();
            btnRegisterRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 524);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 44;
            label1.Text = "Show password";
            // 
            // checkBoxRegister
            // 
            checkBoxRegister.AutoSize = true;
            checkBoxRegister.Location = new Point(290, 524);
            checkBoxRegister.Margin = new Padding(3, 4, 3, 4);
            checkBoxRegister.Name = "checkBoxRegister";
            checkBoxRegister.Size = new Size(18, 17);
            checkBoxRegister.TabIndex = 43;
            checkBoxRegister.UseVisualStyleBackColor = true;
            checkBoxRegister.CheckedChanged += checkBoxRegister_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 448);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 42;
            label3.Text = "Confirm password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 367);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 41;
            label2.Text = "Password";
            // 
            // txtRegisterPasswordConfirm
            // 
            txtRegisterPasswordConfirm.Location = new Point(88, 472);
            txtRegisterPasswordConfirm.Margin = new Padding(3, 4, 3, 4);
            txtRegisterPasswordConfirm.Name = "txtRegisterPasswordConfirm";
            txtRegisterPasswordConfirm.Size = new Size(227, 27);
            txtRegisterPasswordConfirm.TabIndex = 40;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(88, 391);
            txtRegisterPassword.Margin = new Padding(3, 4, 3, 4);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(227, 27);
            txtRegisterPassword.TabIndex = 39;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 275);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 47;
            label6.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(88, 299);
            txtRegisterUsername.Margin = new Padding(3, 4, 3, 4);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(227, 27);
            txtRegisterUsername.TabIndex = 45;
            // 
            // comboBoxRegisterRole
            // 
            comboBoxRegisterRole.BackColor = SystemColors.HighlightText;
            comboBoxRegisterRole.ForeColor = SystemColors.InfoText;
            comboBoxRegisterRole.FormattingEnabled = true;
            comboBoxRegisterRole.Items.AddRange(new object[] { "Student", "Teacher", "Technician", "Admin" });
            comboBoxRegisterRole.Location = new Point(88, 573);
            comboBoxRegisterRole.Margin = new Padding(3, 4, 3, 4);
            comboBoxRegisterRole.Name = "comboBoxRegisterRole";
            comboBoxRegisterRole.Size = new Size(227, 28);
            comboBoxRegisterRole.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 549);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
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
            btnRegisterRegister.Location = new Point(161, 677);
            btnRegisterRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegisterRegister.Name = "btnRegisterRegister";
            btnRegisterRegister.Size = new Size(93, 37);
            btnRegisterRegister.TabIndex = 51;
            btnRegisterRegister.Text = "Register";
            btnRegisterRegister.UseVisualStyleBackColor = false;
            btnRegisterRegister.Click += btnRegisterRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(411, 760);
            Controls.Add(btnRegisterRegister);
            Controls.Add(comboBoxRegisterRole);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtRegisterUsername);
            Controls.Add(label1);
            Controls.Add(checkBoxRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRegisterPasswordConfirm);
            Controls.Add(txtRegisterPassword);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label6;
        private TextBox txtRegisterUsername;
        private ComboBox comboBoxRegisterRole;
        private Label label4;
        private Button btnRegisterRegister;
    }
}
namespace SchoolLabApp.View
{
    partial class Login
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
            label3 = new Label();
            label2 = new Label();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            label1 = new Label();
            checkBoxLogin = new CheckBox();
            btnLoginLogin = new Button();
            btnLoginRegister = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 225);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 30;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 164);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 29;
            label2.Text = "Username";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(70, 243);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(199, 23);
            txtLoginPassword.TabIndex = 28;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(70, 182);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(199, 23);
            txtLoginUsername.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 282);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 38;
            label1.Text = "Show password";
            // 
            // checkBoxLogin
            // 
            checkBoxLogin.AutoSize = true;
            checkBoxLogin.Location = new Point(247, 282);
            checkBoxLogin.Name = "checkBoxLogin";
            checkBoxLogin.Size = new Size(15, 14);
            checkBoxLogin.TabIndex = 37;
            checkBoxLogin.UseVisualStyleBackColor = true;
            checkBoxLogin.CheckedChanged += checkBoxLogin_CheckedChanged;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.White;
            btnLoginLogin.FlatAppearance.BorderColor = Color.Black;
            btnLoginLogin.FlatAppearance.BorderSize = 4;
            btnLoginLogin.FlatStyle = FlatStyle.Popup;
            btnLoginLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLoginLogin.Location = new Point(70, 361);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(87, 28);
            btnLoginLogin.TabIndex = 39;
            btnLoginLogin.Text = "Log in";
            btnLoginLogin.UseVisualStyleBackColor = false;
            // 
            // btnLoginRegister
            // 
            btnLoginRegister.BackColor = Color.White;
            btnLoginRegister.FlatAppearance.BorderColor = Color.Black;
            btnLoginRegister.FlatAppearance.BorderSize = 4;
            btnLoginRegister.FlatStyle = FlatStyle.Popup;
            btnLoginRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnLoginRegister.Location = new Point(188, 361);
            btnLoginRegister.Name = "btnLoginRegister";
            btnLoginRegister.Size = new Size(81, 28);
            btnLoginRegister.TabIndex = 40;
            btnLoginRegister.Text = "Register";
            btnLoginRegister.UseVisualStyleBackColor = false;
            btnLoginRegister.Click += btnLoginRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(357, 453);
            Controls.Add(btnLoginRegister);
            Controls.Add(btnLoginLogin);
            Controls.Add(label1);
            Controls.Add(checkBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private Label label1;
        private CheckBox checkBoxLogin;
        private Button btnLoginLogin;
        private Button btnLoginRegister;
    }
}
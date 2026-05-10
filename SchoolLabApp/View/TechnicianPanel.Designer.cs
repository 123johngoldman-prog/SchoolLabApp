namespace SchoolLabApp.View
{
    partial class TechnicianPanel
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
            comboBoxTechnicianPanelCategory = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxTechnicianPanel = new ListBox();
            txtTechnicianPanelDescription = new TextBox();
            txtTechnicianPanelName = new TextBox();
            btnTechnicianPanelDelete = new Button();
            btnTechnicianPanelEdit = new Button();
            btnTechnicianPanelAdd = new Button();
            btnTechnicianPanelReportPanel = new Button();
            groupStatus = new GroupBox();
            radioButtonTechnicianPanelStatusBroken = new RadioButton();
            radioButtonTechnicianPanelStatusUnavelible = new RadioButton();
            radioButtonTechnicianPanelStatusAvelible = new RadioButton();
            groupStatus.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxTechnicianPanelCategory
            // 
            comboBoxTechnicianPanelCategory.FormattingEnabled = true;
            comboBoxTechnicianPanelCategory.Items.AddRange(new object[] { "Computers", "Lab equipment", "Books" });
            comboBoxTechnicianPanelCategory.Location = new Point(26, 55);
            comboBoxTechnicianPanelCategory.Name = "comboBoxTechnicianPanelCategory";
            comboBoxTechnicianPanelCategory.Size = new Size(199, 23);
            comboBoxTechnicianPanelCategory.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 163);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 26;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 25;
            label2.Text = "Name";
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
            // listBoxTechnicianPanel
            // 
            listBoxTechnicianPanel.ForeColor = SystemColors.Window;
            listBoxTechnicianPanel.FormattingEnabled = true;
            listBoxTechnicianPanel.Location = new Point(272, 26);
            listBoxTechnicianPanel.Name = "listBoxTechnicianPanel";
            listBoxTechnicianPanel.Size = new Size(502, 349);
            listBoxTechnicianPanel.TabIndex = 20;
            // 
            // txtTechnicianPanelDescription
            // 
            txtTechnicianPanelDescription.Location = new Point(26, 181);
            txtTechnicianPanelDescription.Multiline = true;
            txtTechnicianPanelDescription.Name = "txtTechnicianPanelDescription";
            txtTechnicianPanelDescription.Size = new Size(199, 23);
            txtTechnicianPanelDescription.TabIndex = 17;
            // 
            // txtTechnicianPanelName
            // 
            txtTechnicianPanelName.Location = new Point(26, 120);
            txtTechnicianPanelName.Name = "txtTechnicianPanelName";
            txtTechnicianPanelName.Size = new Size(199, 23);
            txtTechnicianPanelName.TabIndex = 16;
            // 
            // btnTechnicianPanelDelete
            // 
            btnTechnicianPanelDelete.BackColor = Color.OrangeRed;
            btnTechnicianPanelDelete.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelDelete.Location = new Point(643, 394);
            btnTechnicianPanelDelete.Name = "btnTechnicianPanelDelete";
            btnTechnicianPanelDelete.Size = new Size(112, 28);
            btnTechnicianPanelDelete.TabIndex = 35;
            btnTechnicianPanelDelete.Text = "Delete";
            btnTechnicianPanelDelete.UseVisualStyleBackColor = false;
            btnTechnicianPanelDelete.Click += btnTechnicianPanelDelete_Click;
            // 
            // btnTechnicianPanelEdit
            // 
            btnTechnicianPanelEdit.BackColor = Color.Aquamarine;
            btnTechnicianPanelEdit.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelEdit.Location = new Point(469, 394);
            btnTechnicianPanelEdit.Name = "btnTechnicianPanelEdit";
            btnTechnicianPanelEdit.Size = new Size(112, 28);
            btnTechnicianPanelEdit.TabIndex = 34;
            btnTechnicianPanelEdit.Text = "Edit";
            btnTechnicianPanelEdit.UseVisualStyleBackColor = false;
            btnTechnicianPanelEdit.Click += btnTechnicianPanelEdit_Click;
            // 
            // btnTechnicianPanelAdd
            // 
            btnTechnicianPanelAdd.BackColor = Color.YellowGreen;
            btnTechnicianPanelAdd.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelAdd.Location = new Point(297, 394);
            btnTechnicianPanelAdd.Name = "btnTechnicianPanelAdd";
            btnTechnicianPanelAdd.Size = new Size(112, 28);
            btnTechnicianPanelAdd.TabIndex = 33;
            btnTechnicianPanelAdd.Text = "Add";
            btnTechnicianPanelAdd.UseVisualStyleBackColor = false;
            btnTechnicianPanelAdd.Click += btnTechnicianPanelAdd_Click;
            // 
            // btnTechnicianPanelReportPanel
            // 
            btnTechnicianPanelReportPanel.BackColor = Color.White;
            btnTechnicianPanelReportPanel.FlatAppearance.BorderColor = Color.Black;
            btnTechnicianPanelReportPanel.FlatAppearance.BorderSize = 4;
            btnTechnicianPanelReportPanel.FlatStyle = FlatStyle.Popup;
            btnTechnicianPanelReportPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnTechnicianPanelReportPanel.Location = new Point(75, 394);
            btnTechnicianPanelReportPanel.Name = "btnTechnicianPanelReportPanel";
            btnTechnicianPanelReportPanel.Size = new Size(112, 28);
            btnTechnicianPanelReportPanel.TabIndex = 32;
            btnTechnicianPanelReportPanel.Text = "Report Panel";
            btnTechnicianPanelReportPanel.UseVisualStyleBackColor = false;
            btnTechnicianPanelReportPanel.Click += btnTechnicianPanelReportPanel_Click;
            // 
            // groupStatus
            // 
            groupStatus.Controls.Add(radioButtonTechnicianPanelStatusBroken);
            groupStatus.Controls.Add(radioButtonTechnicianPanelStatusUnavelible);
            groupStatus.Controls.Add(radioButtonTechnicianPanelStatusAvelible);
            groupStatus.Location = new Point(26, 235);
            groupStatus.Name = "groupStatus";
            groupStatus.Size = new Size(171, 119);
            groupStatus.TabIndex = 36;
            groupStatus.TabStop = false;
            groupStatus.Text = "Status";
            // 
            // radioButtonTechnicianPanelStatusBroken
            // 
            radioButtonTechnicianPanelStatusBroken.AutoSize = true;
            radioButtonTechnicianPanelStatusBroken.Location = new Point(6, 69);
            radioButtonTechnicianPanelStatusBroken.Name = "radioButtonTechnicianPanelStatusBroken";
            radioButtonTechnicianPanelStatusBroken.Size = new Size(62, 19);
            radioButtonTechnicianPanelStatusBroken.TabIndex = 34;
            radioButtonTechnicianPanelStatusBroken.TabStop = true;
            radioButtonTechnicianPanelStatusBroken.Text = "Broken";
            radioButtonTechnicianPanelStatusBroken.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnicianPanelStatusUnavelible
            // 
            radioButtonTechnicianPanelStatusUnavelible.AutoSize = true;
            radioButtonTechnicianPanelStatusUnavelible.Location = new Point(6, 44);
            radioButtonTechnicianPanelStatusUnavelible.Name = "radioButtonTechnicianPanelStatusUnavelible";
            radioButtonTechnicianPanelStatusUnavelible.Size = new Size(80, 19);
            radioButtonTechnicianPanelStatusUnavelible.TabIndex = 33;
            radioButtonTechnicianPanelStatusUnavelible.TabStop = true;
            radioButtonTechnicianPanelStatusUnavelible.Text = "Unavelible";
            radioButtonTechnicianPanelStatusUnavelible.UseVisualStyleBackColor = true;
            // 
            // radioButtonTechnicianPanelStatusAvelible
            // 
            radioButtonTechnicianPanelStatusAvelible.AutoSize = true;
            radioButtonTechnicianPanelStatusAvelible.Location = new Point(6, 19);
            radioButtonTechnicianPanelStatusAvelible.Name = "radioButtonTechnicianPanelStatusAvelible";
            radioButtonTechnicianPanelStatusAvelible.Size = new Size(67, 19);
            radioButtonTechnicianPanelStatusAvelible.TabIndex = 32;
            radioButtonTechnicianPanelStatusAvelible.TabStop = true;
            radioButtonTechnicianPanelStatusAvelible.Text = "Avelible";
            radioButtonTechnicianPanelStatusAvelible.UseVisualStyleBackColor = true;
            // 
            // TechnicianPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupStatus);
            Controls.Add(btnTechnicianPanelDelete);
            Controls.Add(btnTechnicianPanelEdit);
            Controls.Add(btnTechnicianPanelAdd);
            Controls.Add(btnTechnicianPanelReportPanel);
            Controls.Add(comboBoxTechnicianPanelCategory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxTechnicianPanel);
            Controls.Add(txtTechnicianPanelDescription);
            Controls.Add(txtTechnicianPanelName);
            Name = "TechnicianPanel";
            Text = "TechnicianPanel";
            groupStatus.ResumeLayout(false);
            groupStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTechnicianPanelCategory;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxTechnicianPanel;
        private TextBox txtTechnicianPanelDescription;
        private TextBox txtTechnicianPanelName;
        private Button btnTechnicianPanelDelete;
        private Button btnTechnicianPanelEdit;
        private Button btnTechnicianPanelAdd;
        private Button btnTechnicianPanelReportPanel;
        private GroupBox groupStatus;
        private RadioButton radioButtonTechnicianPanelStatusBroken;
        private RadioButton radioButtonTechnicianPanelStatusUnavelible;
        private RadioButton radioButtonTechnicianPanelStatusAvelible;
    }
}
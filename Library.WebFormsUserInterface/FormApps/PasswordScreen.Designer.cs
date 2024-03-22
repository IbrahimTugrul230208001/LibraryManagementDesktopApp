namespace LibraryManagementSystem
{
    partial class PasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLogIn = new System.Windows.Forms.Panel();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ADONETradioButton = new System.Windows.Forms.RadioButton();
            this.TbxUserName = new System.Windows.Forms.TextBox();
            this.EfRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLogIn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WarningLabel
            // 

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(497, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 494);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PanelLogIn
            // 
            this.PanelLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLogIn.Controls.Add(this.TbxPassword);
            this.PanelLogIn.Controls.Add(this.LoginButton);
            this.PanelLogIn.Controls.Add(this.ADONETradioButton);
            this.PanelLogIn.Controls.Add(this.TbxUserName);
            this.PanelLogIn.Controls.Add(this.EfRadioButton);
            this.PanelLogIn.Controls.Add(this.label1);
            this.PanelLogIn.Controls.Add(this.checkBox1);
            this.PanelLogIn.Controls.Add(this.label2);
            this.PanelLogIn.Controls.Add(this.label3);
            this.PanelLogIn.Location = new System.Drawing.Point(25, 124);
            this.PanelLogIn.Name = "PanelLogIn";
            this.PanelLogIn.Size = new System.Drawing.Size(432, 351);
            this.PanelLogIn.TabIndex = 15;
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPassword.Location = new System.Drawing.Point(119, 209);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(186, 20);
            this.TbxPassword.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(119, 251);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(186, 30);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // ADONETradioButton
            // 
            this.ADONETradioButton.AutoSize = true;
            this.ADONETradioButton.Location = new System.Drawing.Point(232, 131);
            this.ADONETradioButton.Name = "ADONETradioButton";
            this.ADONETradioButton.Size = new System.Drawing.Size(73, 17);
            this.ADONETradioButton.TabIndex = 9;
            this.ADONETradioButton.TabStop = true;
            this.ADONETradioButton.Text = "ADO.NET";
            this.ADONETradioButton.UseVisualStyleBackColor = true;
            this.ADONETradioButton.CheckedChanged += new System.EventHandler(this.ADONETradioButton_CheckedChanged_1);
            // 
            // TbxUserName
            // 
            this.TbxUserName.BackColor = System.Drawing.SystemColors.Control;
            this.TbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxUserName.Location = new System.Drawing.Point(119, 173);
            this.TbxUserName.Name = "TbxUserName";
            this.TbxUserName.Size = new System.Drawing.Size(186, 20);
            this.TbxUserName.TabIndex = 2;
            // 
            // EfRadioButton
            // 
            this.EfRadioButton.AutoSize = true;
            this.EfRadioButton.Location = new System.Drawing.Point(119, 131);
            this.EfRadioButton.Name = "EfRadioButton";
            this.EfRadioButton.Size = new System.Drawing.Size(103, 17);
            this.EfRadioButton.TabIndex = 8;
            this.EfRadioButton.TabStop = true;
            this.EfRadioButton.Text = "EntityFramework";
            this.EfRadioButton.UseVisualStyleBackColor = true;
            this.EfRadioButton.CheckedChanged += new System.EventHandler(this.EfRadioButton_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(311, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 45);
            this.panel2.TabIndex = 16;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Library Management Application";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1065, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1110, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelLogIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordScreen";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.PasswordScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLogIn.ResumeLayout(false);
            this.PanelLogIn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelLogIn;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.RadioButton ADONETradioButton;
        private System.Windows.Forms.TextBox TbxUserName;
        private System.Windows.Forms.RadioButton EfRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseButton;
    }
}
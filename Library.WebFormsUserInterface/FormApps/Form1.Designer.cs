namespace LibraryManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReadingPlanPanelBack = new System.Windows.Forms.Panel();
            this.ShopPlanPanelBack = new System.Windows.Forms.Panel();
            this.LibraryPanelBack = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ReadingPlanButton = new System.Windows.Forms.Button();
            this.ShopPlanButton = new System.Windows.Forms.Button();
            this.LibraryButton = new System.Windows.Forms.Button();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BookCountLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DimGray;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1324, -2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 45);
            this.ExitButton.TabIndex = 57;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 45);
            this.panel1.TabIndex = 58;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ReadingPlanPanelBack);
            this.panel2.Controls.Add(this.ShopPlanPanelBack);
            this.panel2.Controls.Add(this.LibraryPanelBack);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.ReadingPlanButton);
            this.panel2.Controls.Add(this.ShopPlanButton);
            this.panel2.Controls.Add(this.LibraryButton);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 720);
            this.panel2.TabIndex = 60;
            // 
            // ReadingPlanPanelBack
            // 
            this.ReadingPlanPanelBack.Location = new System.Drawing.Point(0, 366);
            this.ReadingPlanPanelBack.Name = "ReadingPlanPanelBack";
            this.ReadingPlanPanelBack.Size = new System.Drawing.Size(19, 64);
            this.ReadingPlanPanelBack.TabIndex = 6;
            // 
            // ShopPlanPanelBack
            // 
            this.ShopPlanPanelBack.Location = new System.Drawing.Point(0, 275);
            this.ShopPlanPanelBack.Name = "ShopPlanPanelBack";
            this.ShopPlanPanelBack.Size = new System.Drawing.Size(19, 64);
            this.ShopPlanPanelBack.TabIndex = 5;
            // 
            // LibraryPanelBack
            // 
            this.LibraryPanelBack.Location = new System.Drawing.Point(0, 181);
            this.LibraryPanelBack.Name = "LibraryPanelBack";
            this.LibraryPanelBack.Size = new System.Drawing.Size(19, 64);
            this.LibraryPanelBack.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(35, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Library Management System";
            // 
            // ReadingPlanButton
            // 
            this.ReadingPlanButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.ReadingPlanButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReadingPlanButton.BackgroundImage")));
            this.ReadingPlanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadingPlanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadingPlanButton.FlatAppearance.BorderSize = 0;
            this.ReadingPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadingPlanButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReadingPlanButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReadingPlanButton.Location = new System.Drawing.Point(18, 366);
            this.ReadingPlanButton.Name = "ReadingPlanButton";
            this.ReadingPlanButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.ReadingPlanButton.Size = new System.Drawing.Size(290, 64);
            this.ReadingPlanButton.TabIndex = 2;
            this.ReadingPlanButton.Text = "Reading Plan";
            this.ReadingPlanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadingPlanButton.UseVisualStyleBackColor = false;
            this.ReadingPlanButton.Click += new System.EventHandler(this.ReadingPlanButton_Click);
            // 
            // ShopPlanButton
            // 
            this.ShopPlanButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.ShopPlanButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShopPlanButton.BackgroundImage")));
            this.ShopPlanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShopPlanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopPlanButton.FlatAppearance.BorderSize = 0;
            this.ShopPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopPlanButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShopPlanButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ShopPlanButton.Location = new System.Drawing.Point(18, 275);
            this.ShopPlanButton.Name = "ShopPlanButton";
            this.ShopPlanButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.ShopPlanButton.Size = new System.Drawing.Size(290, 64);
            this.ShopPlanButton.TabIndex = 1;
            this.ShopPlanButton.Text = "Shop Plan";
            this.ShopPlanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShopPlanButton.UseVisualStyleBackColor = false;
            this.ShopPlanButton.Click += new System.EventHandler(this.ShopPlanButton_Click);
            // 
            // LibraryButton
            // 
            this.LibraryButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.LibraryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibraryButton.BackgroundImage")));
            this.LibraryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LibraryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibraryButton.FlatAppearance.BorderSize = 0;
            this.LibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibraryButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LibraryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LibraryButton.Location = new System.Drawing.Point(19, 181);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.LibraryButton.Size = new System.Drawing.Size(290, 64);
            this.LibraryButton.TabIndex = 0;
            this.LibraryButton.Text = "Library";
            this.LibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LibraryButton.UseVisualStyleBackColor = false;
            this.LibraryButton.Click += new System.EventHandler(this.LibraryButton_Click);
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Controls.Add(this.panel5);
            this.LibraryPanel.Controls.Add(this.HelloLabel);
            this.LibraryPanel.Controls.Add(this.panel6);
            this.LibraryPanel.Controls.Add(this.label2);
            this.LibraryPanel.Controls.Add(this.label1);
            this.LibraryPanel.Location = new System.Drawing.Point(309, 44);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(1061, 720);
            this.LibraryPanel.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.BookCountLabel);
            this.panel5.Location = new System.Drawing.Point(418, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 154);
            this.panel5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Books";
            // 
            // BookCountLabel
            // 
            this.BookCountLabel.AutoSize = true;
            this.BookCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookCountLabel.ForeColor = System.Drawing.Color.White;
            this.BookCountLabel.Location = new System.Drawing.Point(99, 28);
            this.BookCountLabel.Name = "BookCountLabel";
            this.BookCountLabel.Size = new System.Drawing.Size(51, 55);
            this.BookCountLabel.TabIndex = 1;
            this.BookCountLabel.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(418, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 56);
            this.panel6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "You Have Total Of";
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelloLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelloLabel.Location = new System.Drawing.Point(286, 43);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(201, 73);
            this.HelloLabel.TabIndex = 3;
            this.HelloLabel.Text = "Hello ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(205, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make a Selection on left side to navigate between pages.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(127, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 764);
            this.Controls.Add(this.LibraryPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LibraryButton;
        private System.Windows.Forms.Button ReadingPlanButton;
        private System.Windows.Forms.Button ShopPlanButton;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label BookCountLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ReadingPlanPanelBack;
        private System.Windows.Forms.Panel ShopPlanPanelBack;
        private System.Windows.Forms.Panel LibraryPanelBack;
    }
}
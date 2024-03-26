namespace Library.WebFormsUserInterface
{
    partial class BookShopListPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label19 = new System.Windows.Forms.Label();
            this.circularProgressBarUserScore = new CircularProgressBar.CircularProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddButton = new System.Windows.Forms.Button();
            this.tbAddUserScore = new System.Windows.Forms.TextBox();
            this.tbAddTotalOfPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddPrice = new System.Windows.Forms.TextBox();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddLibraryButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpdateUserScore = new System.Windows.Forms.TextBox();
            this.tbUpdateTotalOfPages = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbUpdateCategory = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbUpdateButton = new System.Windows.Forms.Button();
            this.tbUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panelCategoryCounts = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panelCategoryCounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(242, 13);
            this.label19.TabIndex = 68;
            this.label19.Text = "Note: Progress bar displays an approximate value.";
            // 
            // circularProgressBarUserScore
            // 
            this.circularProgressBarUserScore.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarUserScore.AnimationSpeed = 500;
            this.circularProgressBarUserScore.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBarUserScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarUserScore.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarUserScore.InnerMargin = 2;
            this.circularProgressBarUserScore.InnerWidth = -1;
            this.circularProgressBarUserScore.Location = new System.Drawing.Point(19, 58);
            this.circularProgressBarUserScore.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarUserScore.Name = "circularProgressBarUserScore";
            this.circularProgressBarUserScore.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarUserScore.OuterMargin = -25;
            this.circularProgressBarUserScore.OuterWidth = 26;
            this.circularProgressBarUserScore.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarUserScore.ProgressWidth = 25;
            this.circularProgressBarUserScore.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarUserScore.Size = new System.Drawing.Size(283, 279);
            this.circularProgressBarUserScore.StartAngle = 270;
            this.circularProgressBarUserScore.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarUserScore.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarUserScore.SubscriptText = "";
            this.circularProgressBarUserScore.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarUserScore.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarUserScore.SuperscriptText = "⭐";
            this.circularProgressBarUserScore.TabIndex = 67;
            this.circularProgressBarUserScore.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarUserScore.Value = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(102, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 19);
            this.label15.TabIndex = 66;
            this.label15.Text = "USER SCORE";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Location = new System.Drawing.Point(894, 31);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 23);
            this.DeleteButton.TabIndex = 65;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 279);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbAddButton);
            this.groupBox3.Controls.Add(this.tbAddUserScore);
            this.groupBox3.Controls.Add(this.tbAddTotalOfPages);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbAddCategory);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbAddPrice);
            this.groupBox3.Controls.Add(this.tbAddAuthor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbAddName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(679, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 312);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "User Score";
            // 
            // tbAddButton
            // 
            this.tbAddButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAddButton.FlatAppearance.BorderSize = 0;
            this.tbAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.tbAddButton.Location = new System.Drawing.Point(125, 246);
            this.tbAddButton.Name = "tbAddButton";
            this.tbAddButton.Size = new System.Drawing.Size(157, 23);
            this.tbAddButton.TabIndex = 28;
            this.tbAddButton.Text = "Add";
            this.tbAddButton.UseVisualStyleBackColor = false;
            this.tbAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tbAddUserScore
            // 
            this.tbAddUserScore.Location = new System.Drawing.Point(125, 208);
            this.tbAddUserScore.Name = "tbAddUserScore";
            this.tbAddUserScore.Size = new System.Drawing.Size(157, 20);
            this.tbAddUserScore.TabIndex = 31;
            // 
            // tbAddTotalOfPages
            // 
            this.tbAddTotalOfPages.Location = new System.Drawing.Point(125, 142);
            this.tbAddTotalOfPages.Name = "tbAddTotalOfPages";
            this.tbAddTotalOfPages.Size = new System.Drawing.Size(157, 20);
            this.tbAddTotalOfPages.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total Of Pages";
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.Location = new System.Drawing.Point(125, 111);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(157, 20);
            this.tbAddCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Price";
            // 
            // tbAddPrice
            // 
            this.tbAddPrice.Location = new System.Drawing.Point(125, 179);
            this.tbAddPrice.Name = "tbAddPrice";
            this.tbAddPrice.Size = new System.Drawing.Size(157, 20);
            this.tbAddPrice.TabIndex = 25;
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Location = new System.Drawing.Point(125, 78);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(157, 20);
            this.tbAddAuthor.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Author";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(125, 41);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(157, 20);
            this.tbAddName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Category";
            // 
            // AddLibraryButton
            // 
            this.AddLibraryButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.AddLibraryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddLibraryButton.FlatAppearance.BorderSize = 0;
            this.AddLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLibraryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddLibraryButton.Location = new System.Drawing.Point(42, 377);
            this.AddLibraryButton.Name = "AddLibraryButton";
            this.AddLibraryButton.Size = new System.Drawing.Size(230, 31);
            this.AddLibraryButton.TabIndex = 61;
            this.AddLibraryButton.Text = "Click to Add Selected book to the Library!";
            this.AddLibraryButton.UseVisualStyleBackColor = false;
            this.AddLibraryButton.Click += new System.EventHandler(this.AddLibraryButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.tbUpdateUserScore);
            this.groupBox6.Controls.Add(this.tbUpdateTotalOfPages);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.tbUpdateCategory);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.tbUpdateButton);
            this.groupBox6.Controls.Add(this.tbUpdatePrice);
            this.groupBox6.Controls.Add(this.tbUpdateAuthor);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.tbUpdateName);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Location = new System.Drawing.Point(327, 358);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 312);
            this.groupBox6.TabIndex = 62;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "User Score";
            // 
            // tbUpdateUserScore
            // 
            this.tbUpdateUserScore.Location = new System.Drawing.Point(125, 205);
            this.tbUpdateUserScore.Name = "tbUpdateUserScore";
            this.tbUpdateUserScore.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateUserScore.TabIndex = 29;
            // 
            // tbUpdateTotalOfPages
            // 
            this.tbUpdateTotalOfPages.Location = new System.Drawing.Point(125, 139);
            this.tbUpdateTotalOfPages.Name = "tbUpdateTotalOfPages";
            this.tbUpdateTotalOfPages.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateTotalOfPages.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Total Of Pages";
            // 
            // tbUpdateCategory
            // 
            this.tbUpdateCategory.Location = new System.Drawing.Point(125, 104);
            this.tbUpdateCategory.Name = "tbUpdateCategory";
            this.tbUpdateCategory.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateCategory.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(71, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Price";
            // 
            // tbUpdateButton
            // 
            this.tbUpdateButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbUpdateButton.FlatAppearance.BorderSize = 0;
            this.tbUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbUpdateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.tbUpdateButton.Location = new System.Drawing.Point(125, 246);
            this.tbUpdateButton.Name = "tbUpdateButton";
            this.tbUpdateButton.Size = new System.Drawing.Size(157, 23);
            this.tbUpdateButton.TabIndex = 9;
            this.tbUpdateButton.Text = "Update";
            this.tbUpdateButton.UseVisualStyleBackColor = false;
            this.tbUpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tbUpdatePrice
            // 
            this.tbUpdatePrice.Location = new System.Drawing.Point(125, 175);
            this.tbUpdatePrice.Name = "tbUpdatePrice";
            this.tbUpdatePrice.Size = new System.Drawing.Size(157, 20);
            this.tbUpdatePrice.TabIndex = 25;
            // 
            // tbUpdateAuthor
            // 
            this.tbUpdateAuthor.Location = new System.Drawing.Point(125, 67);
            this.tbUpdateAuthor.Name = "tbUpdateAuthor";
            this.tbUpdateAuthor.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateAuthor.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(67, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(63, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Author";
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Location = new System.Drawing.Point(125, 34);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateName.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(52, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Category";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panelCategoryCounts);
            this.groupBox7.Location = new System.Drawing.Point(19, 414);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(302, 234);
            this.groupBox7.TabIndex = 64;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Categories";
            // 
            // panelCategoryCounts
            // 
            this.panelCategoryCounts.Controls.Add(this.button2);
            this.panelCategoryCounts.Location = new System.Drawing.Point(23, 29);
            this.panelCategoryCounts.Name = "panelCategoryCounts";
            this.panelCategoryCounts.Size = new System.Drawing.Size(260, 184);
            this.panelCategoryCounts.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(582, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BookShopListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.circularProgressBarUserScore);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AddLibraryButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Name = "BookShopListPage";
            this.Size = new System.Drawing.Size(1060, 719);
            this.Load += new System.EventHandler(this.BookShopListPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panelCategoryCounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private CircularProgressBar.CircularProgressBar circularProgressBarUserScore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tbAddButton;
        private System.Windows.Forms.TextBox tbAddTotalOfPages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddPrice;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddLibraryButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbUpdateTotalOfPages;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbUpdateCategory;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button tbUpdateButton;
        private System.Windows.Forms.TextBox tbUpdatePrice;
        private System.Windows.Forms.TextBox tbUpdateAuthor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panelCategoryCounts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddUserScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUpdateUserScore;
    }
}

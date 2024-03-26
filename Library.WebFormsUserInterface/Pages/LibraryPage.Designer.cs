namespace Library.WebFormsUserInterface.FormApps
{
    partial class LibraryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryPage));
            this.label15 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddButton = new System.Windows.Forms.Button();
            this.tbAddTotalOfPages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddCompletedPages = new System.Windows.Forms.TextBox();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchByAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbUpdateTotalOfPages = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUpdateCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tbUpdateCompletedPages = new System.Windows.Forms.TextBox();
            this.tbUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelCategoryCounts = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CompleteBooksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Note: Progress bar displays an approximate value.";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Location = new System.Drawing.Point(873, 16);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteButton.TabIndex = 65;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 265);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddButton);
            this.groupBox1.Controls.Add(this.tbAddTotalOfPages);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAddCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAddCompletedPages);
            this.groupBox1.Controls.Add(this.tbAddAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAddName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(681, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 274);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add book";
            // 
            // tbAddButton
            // 
            this.tbAddButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAddButton.FlatAppearance.BorderSize = 0;
            this.tbAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.tbAddButton.Location = new System.Drawing.Point(125, 236);
            this.tbAddButton.Name = "tbAddButton";
            this.tbAddButton.Size = new System.Drawing.Size(157, 23);
            this.tbAddButton.TabIndex = 28;
            this.tbAddButton.Text = "Add";
            this.tbAddButton.UseVisualStyleBackColor = false;
            this.tbAddButton.Click += new System.EventHandler(this.tbAddButton_Click);
            // 
            // tbAddTotalOfPages
            // 
            this.tbAddTotalOfPages.Location = new System.Drawing.Point(125, 161);
            this.tbAddTotalOfPages.Name = "tbAddTotalOfPages";
            this.tbAddTotalOfPages.Size = new System.Drawing.Size(157, 20);
            this.tbAddTotalOfPages.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Total Of Pages";
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.Location = new System.Drawing.Point(125, 126);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(157, 20);
            this.tbAddCategory.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Completed Pages";
            // 
            // tbAddCompletedPages
            // 
            this.tbAddCompletedPages.Location = new System.Drawing.Point(125, 201);
            this.tbAddCompletedPages.Name = "tbAddCompletedPages";
            this.tbAddCompletedPages.Size = new System.Drawing.Size(157, 20);
            this.tbAddCompletedPages.TabIndex = 25;
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Location = new System.Drawing.Point(125, 89);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(157, 20);
            this.tbAddAuthor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(125, 56);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(157, 20);
            this.tbAddName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(31, 43);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.SystemColors.ControlText;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(273, 279);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 64;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxCategories);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbSearchByAuthor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbSearchByName);
            this.groupBox3.Location = new System.Drawing.Point(330, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 101);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search with filter";
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Items.AddRange(new object[] {
            "",
            "Din",
            "Fen",
            "Tarih",
            "Psikoloji",
            "Edebiyat"});
            this.cbxCategories.Location = new System.Drawing.Point(529, 43);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(111, 21);
            this.cbxCategories.TabIndex = 29;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Search by Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Search by Author";
            // 
            // tbSearchByAuthor
            // 
            this.tbSearchByAuthor.Location = new System.Drawing.Point(302, 43);
            this.tbSearchByAuthor.Name = "tbSearchByAuthor";
            this.tbSearchByAuthor.Size = new System.Drawing.Size(115, 20);
            this.tbSearchByAuthor.TabIndex = 27;
            this.tbSearchByAuthor.TextChanged += new System.EventHandler(this.tbSearchByAuthor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Search by Name";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(103, 43);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(99, 20);
            this.tbSearchByName.TabIndex = 25;
            this.tbSearchByName.TextChanged += new System.EventHandler(this.tbSearchByName_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbUpdateTotalOfPages);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbUpdateCategory);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.UpdateButton);
            this.groupBox4.Controls.Add(this.tbUpdateCompletedPages);
            this.groupBox4.Controls.Add(this.tbUpdateAuthor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbUpdateName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(332, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 274);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update book";
            // 
            // tbUpdateTotalOfPages
            // 
            this.tbUpdateTotalOfPages.Location = new System.Drawing.Point(125, 161);
            this.tbUpdateTotalOfPages.Name = "tbUpdateTotalOfPages";
            this.tbUpdateTotalOfPages.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateTotalOfPages.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total Of Pages";
            // 
            // tbUpdateCategory
            // 
            this.tbUpdateCategory.Location = new System.Drawing.Point(125, 126);
            this.tbUpdateCategory.Name = "tbUpdateCategory";
            this.tbUpdateCategory.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateCategory.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Completed Pages";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.Location = new System.Drawing.Point(125, 236);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(157, 23);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tbUpdateCompletedPages
            // 
            this.tbUpdateCompletedPages.Location = new System.Drawing.Point(125, 201);
            this.tbUpdateCompletedPages.Name = "tbUpdateCompletedPages";
            this.tbUpdateCompletedPages.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateCompletedPages.TabIndex = 25;
            // 
            // tbUpdateAuthor
            // 
            this.tbUpdateAuthor.Location = new System.Drawing.Point(125, 89);
            this.tbUpdateAuthor.Name = "tbUpdateAuthor";
            this.tbUpdateAuthor.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateAuthor.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Author";
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Location = new System.Drawing.Point(125, 56);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(157, 20);
            this.tbUpdateName.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelCategoryCounts);
            this.groupBox2.Location = new System.Drawing.Point(24, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 265);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categories";
            // 
            // panelCategoryCounts
            // 
            this.panelCategoryCounts.Location = new System.Drawing.Point(17, 22);
            this.panelCategoryCounts.Name = "panelCategoryCounts";
            this.panelCategoryCounts.Size = new System.Drawing.Size(257, 205);
            this.panelCategoryCounts.TabIndex = 28;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshButton.Location = new System.Drawing.Point(999, 9);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(30, 30);
            this.RefreshButton.TabIndex = 67;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CompleteBooksButton
            // 
            this.CompleteBooksButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.CompleteBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompleteBooksButton.FlatAppearance.BorderSize = 0;
            this.CompleteBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompleteBooksButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CompleteBooksButton.Location = new System.Drawing.Point(330, 14);
            this.CompleteBooksButton.Name = "CompleteBooksButton";
            this.CompleteBooksButton.Size = new System.Drawing.Size(159, 23);
            this.CompleteBooksButton.TabIndex = 68;
            this.CompleteBooksButton.Text = "Display Completed Books";
            this.CompleteBooksButton.UseVisualStyleBackColor = false;
            this.CompleteBooksButton.Click += new System.EventHandler(this.CompleteBooksButton_Click);
            // 
            // LibraryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompleteBooksButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "LibraryPage";
            this.Size = new System.Drawing.Size(1060, 719);
            this.Load += new System.EventHandler(this.LibraryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tbAddButton;
        private System.Windows.Forms.TextBox tbAddTotalOfPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddCompletedPages;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label label6;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchByAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbUpdateTotalOfPages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUpdateCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox tbUpdateCompletedPages;
        private System.Windows.Forms.TextBox tbUpdateAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelCategoryCounts;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CompleteBooksButton;
    }
}

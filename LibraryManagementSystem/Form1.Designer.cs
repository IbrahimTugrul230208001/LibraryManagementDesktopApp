namespace LibraryManagementSystem
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddTotalOfPages = new System.Windows.Forms.TextBox();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.tbAddCompletedPages = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchByAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSearchByCategory = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbUpdateTotalOfPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUpdateCompletedPages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tbUpdateCategory = new System.Windows.Forms.TextBox();
            this.tbUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelCategoryCounts = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1277, 255);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddTotalOfPages);
            this.groupBox1.Controls.Add(this.tbAddCategory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.tbAddCompletedPages);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbAddAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAddName);
            this.groupBox1.Location = new System.Drawing.Point(53, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new book";
            // 
            // tbAddTotalOfPages
            // 
            this.tbAddTotalOfPages.Location = new System.Drawing.Point(350, 82);
            this.tbAddTotalOfPages.Name = "tbAddTotalOfPages";
            this.tbAddTotalOfPages.Size = new System.Drawing.Size(138, 20);
            this.tbAddTotalOfPages.TabIndex = 17;
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.Location = new System.Drawing.Point(101, 117);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(138, 20);
            this.tbAddCategory.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total of Pages";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(352, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddButton.Size = new System.Drawing.Size(136, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tbAddCompletedPages
            // 
            this.tbAddCompletedPages.Location = new System.Drawing.Point(350, 47);
            this.tbAddCompletedPages.Name = "tbAddCompletedPages";
            this.tbAddCompletedPages.Size = new System.Drawing.Size(138, 20);
            this.tbAddCompletedPages.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Completed Pages";
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Location = new System.Drawing.Point(101, 80);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(138, 20);
            this.tbAddAuthor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(101, 47);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(138, 20);
            this.tbAddName.TabIndex = 13;
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(135, 40);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(123, 20);
            this.tbSearchByName.TabIndex = 10;
            this.tbSearchByName.TextChanged += new System.EventHandler(this.tbSearchByName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Search books by Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Search books by Author";
            // 
            // tbSearchByAuthor
            // 
            this.tbSearchByAuthor.Location = new System.Drawing.Point(391, 40);
            this.tbSearchByAuthor.Name = "tbSearchByAuthor";
            this.tbSearchByAuthor.Size = new System.Drawing.Size(122, 20);
            this.tbSearchByAuthor.TabIndex = 12;
            this.tbSearchByAuthor.TextChanged += new System.EventHandler(this.tbSearchByAuthor_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Search books by Category";
            // 
            // tbSearchByCategory
            // 
            this.tbSearchByCategory.Location = new System.Drawing.Point(657, 40);
            this.tbSearchByCategory.Name = "tbSearchByCategory";
            this.tbSearchByCategory.Size = new System.Drawing.Size(123, 20);
            this.tbSearchByCategory.TabIndex = 14;
            this.tbSearchByCategory.TextChanged += new System.EventHandler(this.tbSearchByCategory_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbSearchByName);
            this.groupBox3.Controls.Add(this.tbSearchByCategory);
            this.groupBox3.Controls.Add(this.tbSearchByAuthor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 92);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search with filter";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(919, 368);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(350, 23);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(927, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "STATS OF THE BOOK";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbUpdateTotalOfPages);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbUpdateCompletedPages);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.UpdateButton);
            this.groupBox4.Controls.Add(this.tbUpdateCategory);
            this.groupBox4.Controls.Add(this.tbUpdateAuthor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbUpdateName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(919, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 235);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update book data";
            // 
            // tbUpdateTotalOfPages
            // 
            this.tbUpdateTotalOfPages.Location = new System.Drawing.Point(143, 170);
            this.tbUpdateTotalOfPages.Name = "tbUpdateTotalOfPages";
            this.tbUpdateTotalOfPages.Size = new System.Drawing.Size(159, 20);
            this.tbUpdateTotalOfPages.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total of Pages";
            // 
            // tbUpdateCompletedPages
            // 
            this.tbUpdateCompletedPages.Location = new System.Drawing.Point(143, 135);
            this.tbUpdateCompletedPages.Name = "tbUpdateCompletedPages";
            this.tbUpdateCompletedPages.Size = new System.Drawing.Size(159, 20);
            this.tbUpdateCompletedPages.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Completed Pages";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(143, 206);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(159, 23);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tbUpdateCategory
            // 
            this.tbUpdateCategory.Location = new System.Drawing.Point(143, 97);
            this.tbUpdateCategory.Name = "tbUpdateCategory";
            this.tbUpdateCategory.Size = new System.Drawing.Size(159, 20);
            this.tbUpdateCategory.TabIndex = 6;
            // 
            // tbUpdateAuthor
            // 
            this.tbUpdateAuthor.Location = new System.Drawing.Point(143, 60);
            this.tbUpdateAuthor.Name = "tbUpdateAuthor";
            this.tbUpdateAuthor.Size = new System.Drawing.Size(159, 20);
            this.tbUpdateAuthor.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Author";
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Location = new System.Drawing.Point(143, 27);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(159, 20);
            this.tbUpdateName.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Category";
            // 
            // panelCategoryCounts
            // 
            this.panelCategoryCounts.Location = new System.Drawing.Point(23, 20);
            this.panelCategoryCounts.Name = "panelCategoryCounts";
            this.panelCategoryCounts.Size = new System.Drawing.Size(260, 130);
            this.panelCategoryCounts.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelCategoryCounts);
            this.groupBox2.Location = new System.Drawing.Point(601, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 182);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox tbAddCategory;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearchByAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSearchByCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbUpdateTotalOfPages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUpdateCompletedPages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox tbUpdateCategory;
        private System.Windows.Forms.TextBox tbUpdateAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAddTotalOfPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddCompletedPages;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelCategoryCounts;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


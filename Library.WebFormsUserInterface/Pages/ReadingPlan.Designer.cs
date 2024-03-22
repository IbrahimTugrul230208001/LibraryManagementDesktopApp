namespace Library.WebFormsUserInterface.FormApps
{
    partial class ReadingPlan
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
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.cbxSwitchColor = new System.Windows.Forms.ComboBox();
            this.panelBookData = new System.Windows.Forms.Panel();
            this.panelReadPagesData = new System.Windows.Forms.Panel();
            this.panelReadBooksData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.tbAddReadPages = new System.Windows.Forms.TextBox();
            this.tbAddTotalOfPages = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUpdateCategory = new System.Windows.Forms.TextBox();
            this.tbUpdateTotalOfPages = new System.Windows.Forms.TextBox();
            this.tbUpdateReadPages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IncrementReadPages = new System.Windows.Forms.Button();
            this.DecrementReadPages = new System.Windows.Forms.Button();
            this.DecrementReadBooks = new System.Windows.Forms.Button();
            this.IncrementReadBooks = new System.Windows.Forms.Button();
            this.SetAsReading = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.labelOfReadPages = new System.Windows.Forms.Label();
            this.labelOfReadBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(648, 23);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Purple;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(320, 320);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.SelectColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectColorButton.FlatAppearance.BorderSize = 0;
            this.SelectColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectColorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectColorButton.Location = new System.Drawing.Point(853, 372);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(115, 21);
            this.SelectColorButton.TabIndex = 56;
            this.SelectColorButton.Text = "Select Color";
            this.SelectColorButton.UseVisualStyleBackColor = false;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // cbxSwitchColor
            // 
            this.cbxSwitchColor.FormattingEnabled = true;
            this.cbxSwitchColor.Items.AddRange(new object[] {
            "Red",
            "Gold",
            "Blue",
            "Purple",
            "Green",
            "Orange",
            "Black",
            "Cyan",
            "Light Green",
            "Light Blue",
            "Light Coral",
            "Pink",
            "Turquoise",
            "Lavender",
            "Magenta",
            "Indigo",
            "Coral",
            "Peach",
            "Maroon",
            "Teal",
            "Olive",
            "Slate",
            "Beige",
            "Ivory",
            "Tan",
            "Salmon",
            "Crimson",
            "Plum",
            "Orchid",
            "Khaki",
            "Azure",
            "Mint",
            "BlueViolet",
            "White",
            "PowderBlue",
            "Violet",
            "IndianRed",
            "Silver",
            "Lemon"});
            this.cbxSwitchColor.Location = new System.Drawing.Point(648, 372);
            this.cbxSwitchColor.Name = "cbxSwitchColor";
            this.cbxSwitchColor.Size = new System.Drawing.Size(199, 21);
            this.cbxSwitchColor.TabIndex = 55;
            this.cbxSwitchColor.Text = "Select Progress Bar Color";
            // 
            // panelBookData
            // 
            this.panelBookData.Location = new System.Drawing.Point(601, 423);
            this.panelBookData.Name = "panelBookData";
            this.panelBookData.Size = new System.Drawing.Size(422, 72);
            this.panelBookData.TabIndex = 57;
            // 
            // panelReadPagesData
            // 
            this.panelReadPagesData.Location = new System.Drawing.Point(601, 551);
            this.panelReadPagesData.Name = "panelReadPagesData";
            this.panelReadPagesData.Size = new System.Drawing.Size(208, 69);
            this.panelReadPagesData.TabIndex = 58;
            // 
            // panelReadBooksData
            // 
            this.panelReadBooksData.Location = new System.Drawing.Point(815, 551);
            this.panelReadBooksData.Name = "panelReadBooksData";
            this.panelReadBooksData.Size = new System.Drawing.Size(208, 69);
            this.panelReadBooksData.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 354);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAddName);
            this.groupBox1.Controls.Add(this.tbAddAuthor);
            this.groupBox1.Controls.Add(this.tbAddCategory);
            this.groupBox1.Controls.Add(this.tbAddReadPages);
            this.groupBox1.Controls.Add(this.tbAddTotalOfPages);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 244);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TotalPages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ReadPages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // tbAddName
            // 
            this.tbAddName.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddName.Location = new System.Drawing.Point(77, 29);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(138, 20);
            this.tbAddName.TabIndex = 5;
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddAuthor.Location = new System.Drawing.Point(77, 61);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(138, 20);
            this.tbAddAuthor.TabIndex = 4;
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddCategory.Location = new System.Drawing.Point(77, 94);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(138, 20);
            this.tbAddCategory.TabIndex = 3;
            // 
            // tbAddReadPages
            // 
            this.tbAddReadPages.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddReadPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddReadPages.Location = new System.Drawing.Point(76, 128);
            this.tbAddReadPages.Name = "tbAddReadPages";
            this.tbAddReadPages.Size = new System.Drawing.Size(138, 20);
            this.tbAddReadPages.TabIndex = 2;
            // 
            // tbAddTotalOfPages
            // 
            this.tbAddTotalOfPages.BackColor = System.Drawing.SystemColors.Control;
            this.tbAddTotalOfPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddTotalOfPages.Location = new System.Drawing.Point(76, 163);
            this.tbAddTotalOfPages.Name = "tbAddTotalOfPages";
            this.tbAddTotalOfPages.Size = new System.Drawing.Size(138, 20);
            this.tbAddTotalOfPages.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(76, 206);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(138, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbUpdateName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.UpdateButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbUpdateAuthor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbUpdateCategory);
            this.groupBox2.Controls.Add(this.tbUpdateTotalOfPages);
            this.groupBox2.Controls.Add(this.tbUpdateReadPages);
            this.groupBox2.Location = new System.Drawing.Point(313, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 243);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Book";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "TotalPages";
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.BackColor = System.Drawing.SystemColors.Control;
            this.tbUpdateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdateName.Location = new System.Drawing.Point(87, 29);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(138, 20);
            this.tbUpdateName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ReadPages";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.Location = new System.Drawing.Point(87, 205);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(138, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Category";
            // 
            // tbUpdateAuthor
            // 
            this.tbUpdateAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.tbUpdateAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdateAuthor.Location = new System.Drawing.Point(87, 60);
            this.tbUpdateAuthor.Name = "tbUpdateAuthor";
            this.tbUpdateAuthor.Size = new System.Drawing.Size(138, 20);
            this.tbUpdateAuthor.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Author";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Name";
            // 
            // tbUpdateCategory
            // 
            this.tbUpdateCategory.BackColor = System.Drawing.SystemColors.Control;
            this.tbUpdateCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdateCategory.Location = new System.Drawing.Point(87, 91);
            this.tbUpdateCategory.Name = "tbUpdateCategory";
            this.tbUpdateCategory.Size = new System.Drawing.Size(138, 20);
            this.tbUpdateCategory.TabIndex = 8;
            // 
            // tbUpdateTotalOfPages
            // 
            this.tbUpdateTotalOfPages.BackColor = System.Drawing.SystemColors.Control;
            this.tbUpdateTotalOfPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdateTotalOfPages.Location = new System.Drawing.Point(87, 162);
            this.tbUpdateTotalOfPages.Name = "tbUpdateTotalOfPages";
            this.tbUpdateTotalOfPages.Size = new System.Drawing.Size(138, 20);
            this.tbUpdateTotalOfPages.TabIndex = 6;
            // 
            // tbUpdateReadPages
            // 
            this.tbUpdateReadPages.BackColor = System.Drawing.SystemColors.Control;
            this.tbUpdateReadPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdateReadPages.Location = new System.Drawing.Point(87, 127);
            this.tbUpdateReadPages.Name = "tbUpdateReadPages";
            this.tbUpdateReadPages.Size = new System.Drawing.Size(138, 20);
            this.tbUpdateReadPages.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(244, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "READING PLAN";
            // 
            // IncrementReadPages
            // 
            this.IncrementReadPages.BackColor = System.Drawing.Color.Maroon;
            this.IncrementReadPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncrementReadPages.FlatAppearance.BorderSize = 0;
            this.IncrementReadPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncrementReadPages.ForeColor = System.Drawing.SystemColors.Control;
            this.IncrementReadPages.Location = new System.Drawing.Point(601, 635);
            this.IncrementReadPages.Name = "IncrementReadPages";
            this.IncrementReadPages.Size = new System.Drawing.Size(101, 23);
            this.IncrementReadPages.TabIndex = 64;
            this.IncrementReadPages.Text = "Increment";
            this.IncrementReadPages.UseVisualStyleBackColor = false;
            this.IncrementReadPages.Click += new System.EventHandler(this.IncrementReadPages_Click);
            // 
            // DecrementReadPages
            // 
            this.DecrementReadPages.BackColor = System.Drawing.Color.Maroon;
            this.DecrementReadPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecrementReadPages.FlatAppearance.BorderSize = 0;
            this.DecrementReadPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecrementReadPages.ForeColor = System.Drawing.SystemColors.Control;
            this.DecrementReadPages.Location = new System.Drawing.Point(708, 635);
            this.DecrementReadPages.Name = "DecrementReadPages";
            this.DecrementReadPages.Size = new System.Drawing.Size(101, 23);
            this.DecrementReadPages.TabIndex = 65;
            this.DecrementReadPages.Text = "Decrement";
            this.DecrementReadPages.UseVisualStyleBackColor = false;
            this.DecrementReadPages.Click += new System.EventHandler(this.DecrementReadPages_Click);
            // 
            // DecrementReadBooks
            // 
            this.DecrementReadBooks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DecrementReadBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecrementReadBooks.FlatAppearance.BorderSize = 0;
            this.DecrementReadBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecrementReadBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.DecrementReadBooks.Location = new System.Drawing.Point(922, 635);
            this.DecrementReadBooks.Name = "DecrementReadBooks";
            this.DecrementReadBooks.Size = new System.Drawing.Size(101, 23);
            this.DecrementReadBooks.TabIndex = 67;
            this.DecrementReadBooks.Text = "Decrement";
            this.DecrementReadBooks.UseVisualStyleBackColor = false;
            this.DecrementReadBooks.Click += new System.EventHandler(this.DecrementReadBooks_Click);
            // 
            // IncrementReadBooks
            // 
            this.IncrementReadBooks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.IncrementReadBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncrementReadBooks.FlatAppearance.BorderSize = 0;
            this.IncrementReadBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncrementReadBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.IncrementReadBooks.Location = new System.Drawing.Point(815, 635);
            this.IncrementReadBooks.Name = "IncrementReadBooks";
            this.IncrementReadBooks.Size = new System.Drawing.Size(101, 23);
            this.IncrementReadBooks.TabIndex = 66;
            this.IncrementReadBooks.Text = "Increment";
            this.IncrementReadBooks.UseVisualStyleBackColor = false;
            this.IncrementReadBooks.Click += new System.EventHandler(this.IncrementReadBooks_Click);
            // 
            // SetAsReading
            // 
            this.SetAsReading.BackColor = System.Drawing.SystemColors.ControlText;
            this.SetAsReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetAsReading.FlatAppearance.BorderSize = 0;
            this.SetAsReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetAsReading.ForeColor = System.Drawing.SystemColors.Control;
            this.SetAsReading.Location = new System.Drawing.Point(24, 20);
            this.SetAsReading.Name = "SetAsReading";
            this.SetAsReading.Size = new System.Drawing.Size(175, 23);
            this.SetAsReading.TabIndex = 16;
            this.SetAsReading.Text = "Set as Currently Reading";
            this.SetAsReading.UseVisualStyleBackColor = false;
            this.SetAsReading.Click += new System.EventHandler(this.SetAsReading_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Location = new System.Drawing.Point(451, 23);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(138, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete Selected Book";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // labelOfReadPages
            // 
            this.labelOfReadPages.AutoSize = true;
            this.labelOfReadPages.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOfReadPages.ForeColor = System.Drawing.Color.Maroon;
            this.labelOfReadPages.Location = new System.Drawing.Point(677, 504);
            this.labelOfReadPages.Name = "labelOfReadPages";
            this.labelOfReadPages.Size = new System.Drawing.Size(40, 44);
            this.labelOfReadPages.TabIndex = 68;
            this.labelOfReadPages.Text = "0";
            // 
            // labelOfReadBooks
            // 
            this.labelOfReadBooks.AutoSize = true;
            this.labelOfReadBooks.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOfReadBooks.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelOfReadBooks.Location = new System.Drawing.Point(901, 504);
            this.labelOfReadBooks.Name = "labelOfReadBooks";
            this.labelOfReadBooks.Size = new System.Drawing.Size(40, 44);
            this.labelOfReadBooks.TabIndex = 69;
            this.labelOfReadBooks.Text = "0";
            // 
            // ReadingPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelOfReadBooks);
            this.Controls.Add(this.labelOfReadPages);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SetAsReading);
            this.Controls.Add(this.DecrementReadBooks);
            this.Controls.Add(this.IncrementReadBooks);
            this.Controls.Add(this.DecrementReadPages);
            this.Controls.Add(this.IncrementReadPages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelReadBooksData);
            this.Controls.Add(this.panelReadPagesData);
            this.Controls.Add(this.panelBookData);
            this.Controls.Add(this.SelectColorButton);
            this.Controls.Add(this.cbxSwitchColor);
            this.Controls.Add(this.circularProgressBar1);
            this.Name = "ReadingPlan";
            this.Size = new System.Drawing.Size(1044, 713);
            this.Load += new System.EventHandler(this.ReadingPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button SelectColorButton;
        private System.Windows.Forms.ComboBox cbxSwitchColor;
        private System.Windows.Forms.Panel panelBookData;
        private System.Windows.Forms.Panel panelReadPagesData;
        private System.Windows.Forms.Panel panelReadBooksData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IncrementReadPages;
        private System.Windows.Forms.Button DecrementReadPages;
        private System.Windows.Forms.Button DecrementReadBooks;
        private System.Windows.Forms.Button IncrementReadBooks;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.TextBox tbAddCategory;
        private System.Windows.Forms.TextBox tbAddReadPages;
        private System.Windows.Forms.TextBox tbAddTotalOfPages;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.TextBox tbUpdateAuthor;
        private System.Windows.Forms.TextBox tbUpdateCategory;
        private System.Windows.Forms.TextBox tbUpdateTotalOfPages;
        private System.Windows.Forms.TextBox tbUpdateReadPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SetAsReading;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label labelOfReadPages;
        private System.Windows.Forms.Label labelOfReadBooks;
    }
}

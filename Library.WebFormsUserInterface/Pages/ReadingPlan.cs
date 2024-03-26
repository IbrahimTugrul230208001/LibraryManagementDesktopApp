using Library.Business.Concrete;
using Library.DataAccess.Abstract.EntityFramework;
using Library.DataAccess.Concrete.ADONET;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUserInterface.FormApps
{
    public partial class ReadingPlan : UserControl
    {
        private string _selectedCompletedPages, _selectedTotalOfPages,
           _selectedBookName, _SelectedBarColor,_AuthorOfSelectedBook,_CategoryOfSelectedBook;
        private decimal _selectedCompletionRate;
        private int _TotalOfBooksRead, _TotalOfPagesHaveBeenRead;
        public LibraryManager _libraryManager;

        public ReadingPlan(string framework)
        {
            InitializeComponent();
            SelectFramework(framework);
        }

        public void SelectFramework(string framework)
        {
            if (framework == "ADONET")
            {
                _libraryManager = new LibraryManager(new ADONET());
            }

            else if (framework == "EntityFramework")
            {
                _libraryManager = new LibraryManager(new EntityFramework());

            }
            else
            {
                throw new ArgumentException("Invalid framework selection");
            }
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            string selectedColor = cbxSwitchColor.SelectedItem.ToString();

            if (selectedColor != _SelectedBarColor)
            {
                ColorSelection(selectedColor);
                _SelectedBarColor = selectedColor;
                Properties.Settings.Default.SelectedBarColor = _SelectedBarColor;
                Properties.Settings.Default.Save();
            }
        }

        private void UpdateCurrentlyReadingBookUI(string currentlyReading, string completedPages, string totalOfPages, decimal completionRate)
        {
            int completionRateInt = Convert.ToInt32(completionRate);

            if (completionRateInt < 0 || completionRateInt > 100)
            {
                MessageBox.Show("Error: Completion rate value out of range (0-100).");
            }

            circularProgressBar1.Value = completionRateInt;
            circularProgressBar1.Text = completionRate.ToString("0.00", CultureInfo.InvariantCulture);
            panelBookData.Controls.Clear();

            Label lblBookName = new Label();
            lblBookName.Text = "Currently Reading: " + currentlyReading;
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(10, 10);
            lblBookName.ForeColor = Color.Black;

            Label lblCompletionStatus = new Label();
            lblCompletionStatus.Text = "Completed " + completedPages + " Pages Out of " + totalOfPages + " Pages";
            lblCompletionStatus.AutoSize = true;


            int lblCompletionStatusY = lblBookName.Bottom + 10;
            lblCompletionStatus.Location = new Point(10, lblCompletionStatusY);

            panelBookData.Controls.Add(lblBookName);
            panelBookData.Controls.Add(lblCompletionStatus);

        }

        private void LoadReadPagesAndBooksLabelsContent()
        {
            labelOfReadPages.Text = Convert.ToString(_TotalOfPagesHaveBeenRead);
            labelOfReadBooks.Text = Convert.ToString(_TotalOfBooksRead);
        }

        private void ReadingPlan_Load(object sender, EventArgs e)
        {
            LoadSelectedBookData();
            UpdateCurrentlyReadingBookUI(_selectedBookName, _selectedCompletedPages, _selectedTotalOfPages, _selectedCompletionRate);
            LoadReadPagesAndBooksLabelsContent();
            DisplayBookAndPageDataPanels();
            LoadCircularProgressBarData();
            LoadPlannedBooksToRead();
            SetDataGridColumnWidth();
        }

        private void SetDataGridColumnWidth()
        {
            dataGridView1.Columns[0].Width = 32;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 85;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 75;
        }
        public void SetPanelData(string currentlyReading, string completedPages, string totalOfPages, decimal completionRate)
        {
            UpdateCurrentlyReadingBookUI(currentlyReading, completedPages, totalOfPages, completionRate);
        }
        private void DisplayBookAndPageDataPanels()
        {
            Label lblTotalOfPages = new Label();

            lblTotalOfPages.Text = "Pages have been read so far.";
            lblTotalOfPages.AutoSize = true;
            lblTotalOfPages.ForeColor = Color.Maroon;
            lblTotalOfPages.Location = new Point(10, 10);
            panelReadPagesData.Controls.Add(lblTotalOfPages);


            Label lblBookAmount = new Label();
            lblBookAmount.AutoSize = true;
            lblBookAmount.Text = "Books have been read so far.";
            lblBookAmount.Location = new Point(10, 10);
            lblBookAmount.ForeColor = Color.DarkSlateBlue;
            panelReadBooksData.Controls.Add(lblBookAmount);
        }


        private void LoadPlannedBooksToRead()
        {
            dataGridView1.DataSource = _libraryManager.GetPlannedBooksToRead();
        }


        private void ClearTextBoxes()
        {
            tbAddAuthor.Text = "";
            tbAddName.Text = "";
            tbAddCategory.Text = "";
            tbAddReadPages.Text = "";
            tbAddTotalOfPages.Text = "";
            tbUpdateAuthor.Text = "";
            tbUpdateCategory.Text = "";
            tbUpdateReadPages.Text = "";
            tbUpdateTotalOfPages.Text = "";
            tbUpdateName.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            tbUpdateAuthor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            tbUpdateCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            tbUpdateReadPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            tbUpdateTotalOfPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _libraryManager.AddToBookPlanList(new PlannedBook
            {
                Name = Convert.ToString(tbAddName.Text),
                Author = Convert.ToString(tbAddAuthor.Text),
                Category = Convert.ToString(tbAddCategory.Text),
                CompletedPages = Convert.ToInt32(tbAddReadPages.Text),
                TotalOfPages = Convert.ToInt32(tbAddTotalOfPages.Text),
            });
            LoadPlannedBooksToRead();
            MessageBox.Show("Book Added!");
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _libraryManager.UpdateBookPlanList(new PlannedBook
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbUpdateName.Text,
                Author = tbUpdateAuthor.Text,
                Category = tbUpdateCategory.Text,
                TotalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text),
                CompletedPages = Convert.ToInt32(tbUpdateReadPages.Text),
            });

            MessageBox.Show("The Book has Been Updated!");
            int completedPages = Convert.ToInt32(tbUpdateReadPages.Text);
            int totalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text);
            decimal completionRateDecimal = (decimal)completedPages / totalOfPages * 100;
            int completionRateInt = (int)completionRateDecimal;
            circularProgressBar1.Value = completionRateInt;
            circularProgressBar1.Text = completionRateDecimal.ToString("0.00", CultureInfo.InvariantCulture);
            SaveCircularProgressBarData(circularProgressBar1.Value, circularProgressBar1.Text);
            UpdateCurrentlyReadingBookUI(tbUpdateName.Text, Convert.ToString(completedPages), Convert.ToString(totalOfPages), completionRateDecimal);
            ClearTextBoxes();
            LoadPlannedBooksToRead();
        }

        private void IncrementReadPages_Click(object sender, EventArgs e)
        {
            int pageAmount = Convert.ToInt32(labelOfReadPages.Text);
            ++pageAmount;
            labelOfReadPages.Text = Convert.ToString(pageAmount);
            _TotalOfPagesHaveBeenRead = pageAmount;
            Properties.Settings.Default.TotalOfPagesRead = _TotalOfPagesHaveBeenRead;
            Properties.Settings.Default.Save();
        }

        private void DecrementReadPages_Click(object sender, EventArgs e)
        {
            int pageAmount = Convert.ToInt32(labelOfReadPages.Text);
            --pageAmount;
            labelOfReadPages.Text = Convert.ToString(pageAmount);
            _TotalOfPagesHaveBeenRead = pageAmount;
            Properties.Settings.Default.TotalOfPagesRead = _TotalOfPagesHaveBeenRead;
            Properties.Settings.Default.Save();
        }

        private void IncrementReadBooks_Click(object sender, EventArgs e)
        {
            int bookAmount = Convert.ToInt32(labelOfReadBooks.Text);
            ++bookAmount;
            labelOfReadBooks.Text = Convert.ToString(bookAmount);
            _TotalOfBooksRead = bookAmount;
            Properties.Settings.Default.TotalOfBooksRead = _TotalOfBooksRead;
            Properties.Settings.Default.Save();
        }

        private void DecrementReadBooks_Click(object sender, EventArgs e)
        {
            int bookAmount = Convert.ToInt32(labelOfReadBooks.Text);
            --bookAmount;
            labelOfReadBooks.Text = Convert.ToString(bookAmount);
            _TotalOfBooksRead = bookAmount;
            Properties.Settings.Default.TotalOfBooksRead = _TotalOfBooksRead;
            Properties.Settings.Default.Save();
        }

        private void SetAsReading_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                _selectedBookName = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                _selectedCompletedPages = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                _selectedTotalOfPages = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                _AuthorOfSelectedBook = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                _CategoryOfSelectedBook = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                int completedPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                int totalOfPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                decimal completionRateDecimal = (decimal)completedPages / totalOfPages * 100;
                _selectedCompletionRate = completionRateDecimal;
                SaveSelectedBookData(_selectedBookName, _selectedCompletedPages, _selectedTotalOfPages, _selectedCompletionRate,_CategoryOfSelectedBook,_AuthorOfSelectedBook);
                UpdateCurrentlyReadingBookUI(_selectedBookName, _selectedCompletedPages, _selectedTotalOfPages, _selectedCompletionRate);
                SaveCircularProgressBarData(circularProgressBar1.Value, circularProgressBar1.Text);
            }
            else
            {
                MessageBox.Show("Please select a book from the DataGridView.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _libraryManager.DeleteBookPlanList(new PlannedBook
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            MessageBox.Show("Book has been Deleted!");
            LoadPlannedBooksToRead();
            ClearTextBoxes();
        }

        private void SaveCircularProgressBarData(int value, string text)
        {
            Properties.Settings.Default.CircularProgressBarValue = value;
            Properties.Settings.Default.CircularProgressBarText = text;
            Properties.Settings.Default.Save();
        }

        private void LoadCircularProgressBarData()
        {
            int value = Properties.Settings.Default.CircularProgressBarValue;
            string text = Properties.Settings.Default.CircularProgressBarText;

            circularProgressBar1.Value = value;
            circularProgressBar1.Text = text;
        }

        private void LoadSelectedBookData()
        {
            _selectedBookName = Properties.Settings.Default.SelectedBookName;
            _selectedCompletedPages = Properties.Settings.Default.SelectedCompletedPages;
            _selectedTotalOfPages = Properties.Settings.Default.SelectedTotalOfPages;
            _selectedCompletionRate = Properties.Settings.Default.SelectedCompletionRate;
            _TotalOfPagesHaveBeenRead = Properties.Settings.Default.TotalOfPagesRead;
            _TotalOfBooksRead = Properties.Settings.Default.TotalOfBooksRead;
            _SelectedBarColor = Properties.Settings.Default.SelectedBarColor;
            ColorSelection(_SelectedBarColor);
        }

        public void SaveSelectedBookData(string selectedBookName,string selectedCompletedPages,string selectedTotalOfPages,decimal selectedCompletionRate,string categoryOfSelectedBook,string authorOfSelectedBook)
        {
            Properties.Settings.Default.SelectedBookName = selectedBookName;
            Properties.Settings.Default.SelectedCompletedPages = selectedCompletedPages;
            Properties.Settings.Default.SelectedTotalOfPages = selectedTotalOfPages;
            Properties.Settings.Default.SelectedCompletionRate = selectedCompletionRate;
            Properties.Settings.Default.CategoryOfSelectedBook = categoryOfSelectedBook;
            Properties.Settings.Default.AuthorOfSelectedBook = authorOfSelectedBook;
            Properties.Settings.Default.Save();
        }



        private void ColorSelection(string color)
        {
            switch (color)
            {
                case "Red":
                    circularProgressBar1.ProgressColor = Color.Red;
                    break;
                case "Green":
                    circularProgressBar1.ProgressColor = Color.Green;
                    break;
                case "Blue":
                    circularProgressBar1.ProgressColor = Color.Blue;
                    break;
                case "Gold":
                    circularProgressBar1.ProgressColor = Color.Gold;
                    break;
                case "Orange":
                    circularProgressBar1.ProgressColor = Color.Orange;
                    break;
                case "Purple":
                    circularProgressBar1.ProgressColor = Color.Purple;
                    break;
                case "Black":
                    circularProgressBar1.ProgressColor = Color.Black;
                    break;
                case "Cyan":
                    circularProgressBar1.ProgressColor = Color.Cyan;
                    break;
                case "Light green":
                    circularProgressBar1.ProgressColor = Color.LightGreen;
                    break;
                case "Light Blue":
                    circularProgressBar1.ProgressColor = Color.LightBlue;
                    break;
                case "Light Coral":
                    circularProgressBar1.ProgressColor = Color.LightCoral;
                    break;
                case "Pink":
                    circularProgressBar1.ProgressColor = Color.Pink;
                    break;
                case "Turquoise":
                    circularProgressBar1.ProgressColor = Color.Turquoise;
                    break;
                case "Lavender":
                    circularProgressBar1.ProgressColor = Color.Lavender;
                    break;
                case "Magenta":
                    circularProgressBar1.ProgressColor = Color.Magenta;
                    break;
                case "Indigo":
                    circularProgressBar1.ProgressColor = Color.Indigo;
                    break;
                case "Coral":
                    circularProgressBar1.ProgressColor = Color.Coral;
                    break;
                case "Peach":
                    circularProgressBar1.ProgressColor = Color.PeachPuff;
                    break;
                case "Maroon":
                    circularProgressBar1.ProgressColor = Color.Maroon;
                    break;
                case "Teal":
                    circularProgressBar1.ProgressColor = Color.Teal;
                    break;
                case "Olive":
                    circularProgressBar1.ProgressColor = Color.Olive;
                    break;
                case "Slate":
                    circularProgressBar1.ProgressColor = Color.MediumPurple;
                    break;
                case "Beige":
                    circularProgressBar1.ProgressColor = Color.Beige;
                    break;
                case "Ivory":
                    circularProgressBar1.ProgressColor = Color.Ivory;
                    break;
                case "Tan":
                    circularProgressBar1.ProgressColor = Color.Tan;
                    break;
                case "Salmon":
                    circularProgressBar1.ProgressColor = Color.Salmon;
                    break;
                case "Crimson":
                    circularProgressBar1.ProgressColor = Color.Crimson;
                    break;
                case "Plum":
                    circularProgressBar1.ProgressColor = Color.Plum;
                    break;
                case "Orchid":
                    circularProgressBar1.ProgressColor = Color.Orchid;
                    break;
                case "Khaki":
                    circularProgressBar1.ProgressColor = Color.Khaki;
                    break;
                case "Azure":
                    circularProgressBar1.ProgressColor = Color.Azure;
                    break;
                case "Mint":
                    circularProgressBar1.ProgressColor = Color.MintCream;
                    break;
                case "BlueViolet":
                    circularProgressBar1.ProgressColor = Color.BlueViolet;
                    break;
                case "White":
                    circularProgressBar1.ProgressColor = Color.White;
                    break;
                case "PowderBlue":
                    circularProgressBar1.ProgressColor = Color.PowderBlue;
                    break;
                case "Violet":
                    circularProgressBar1.ProgressColor = Color.Violet;
                    break;
                case "IndianRed":
                    circularProgressBar1.ProgressColor = Color.IndianRed;
                    break;
                case "Silver":
                    circularProgressBar1.ProgressColor = Color.Silver;
                    break;
                case "Lemon":
                    circularProgressBar1.ProgressColor = Color.LemonChiffon;
                    break;
                default:
                    break;
            }
        }
    }
}

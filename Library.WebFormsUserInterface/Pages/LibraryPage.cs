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
    public partial class LibraryPage : UserControl
    {
        public LibraryPage(string framework)
        {
            InitializeComponent();
            SelectFramework(framework);

        }

        public LibraryManager _libraryManager;


        private void LoadLibrary()
        {
            dataGridView1.DataSource = _libraryManager.GetAll();
            dataGridView1.Columns[0].Width = 34;
            dataGridView1.Columns[1].Width = 154;
            dataGridView1.Columns[2].Width = 150;
        }

        public void SelectFramework(string framework)
        {
            
            if (framework == "ADONET")
            {
                _libraryManager = new LibraryManager(new ADONET());
                LabelFramework.Text += "ADO.NET";
            }
            else if (framework == "EntityFramework")
            {
                _libraryManager = new LibraryManager(new EntityFramework());
                LabelFramework.Text += "EntityFramework";
            }
            else
            {
                throw new ArgumentException("Invalid framework selection");
            }
        }

        private void LibraryPage_Load(object sender, EventArgs e)
        {
            LoadLibrary();
            DisplayBookCountsByCategory();
        }
        
        private void DisplayCompletionRate()
        {

            int completedPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            int totalOfPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            decimal completionRateDecimal = (decimal)completedPages / totalOfPages * 100;
            int completionRate = Convert.ToInt32(completionRateDecimal);
            circularProgressBar1.Value = completionRate;
            circularProgressBar1.Text = completionRateDecimal.ToString("0.00", CultureInfo.InvariantCulture);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            tbUpdateAuthor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            tbUpdateCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            tbUpdateCompletedPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            tbUpdateTotalOfPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            DisplayCompletionRate();
        }

        private void ClearTextBoxes()
        {
            tbAddName.Text = "";
            tbAddCategory.Text = "";
            tbAddCompletedPages.Text = "";
            tbAddTotalOfPages.Text = "";
            tbAddAuthor.Text = "";
            tbUpdateName.Text = "";
            tbUpdateAuthor.Text = "";
            tbUpdateCategory.Text = "";
            tbUpdateCompletedPages.Text = "";
            tbUpdateTotalOfPages.Text = "";
        }

        private void DisplayBookCountsByCategory()
        {
            Dictionary<string, int> categoryCounts;
            int totalBooks;
            categoryCounts = _libraryManager.CountBooksByCategory(out totalBooks);

            panelCategoryCounts.Controls.Clear();

            int yOffset = 10;
            foreach (var kvp in categoryCounts)
            {
                Label label = new Label();
                label.Text = $"{kvp.Key}: {kvp.Value} books";
                label.AutoSize = true;
                label.Location = new Point(10, yOffset);
                panelCategoryCounts.Controls.Add(label);

                yOffset += label.Height + 7;
            }


            Properties.Settings.Default.TotalOfBooks = totalBooks;
            Properties.Settings.Default.Save();
            Label totalLabel = new Label();
            totalLabel.Text = $"Total: {totalBooks} books";
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(10, yOffset);
            panelCategoryCounts.Controls.Add(totalLabel);
        }


        private void tbSearchByName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryManager.SearchBookByName(tbSearchByName.Text);
        }

        private void tbSearchByAuthor_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryManager.SearchBooksByAuthor(tbSearchByAuthor.Text);
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryManager.SearchBooksByCategory(cbxCategories.Text);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Update(new Libraries
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbUpdateName.Text,
                Author = tbUpdateAuthor.Text,
                Category = tbUpdateCategory.Text,
                CompletedPages = Convert.ToInt32(tbUpdateCompletedPages.Text),
                TotalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text)
            });

            MessageBox.Show("Book has been Updated!");
            LoadLibrary();
            DisplayBookCountsByCategory();
            ClearTextBoxes();
        }

        private void tbAddButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Add(new Libraries
            {
                Name = tbAddName.Text,
                Author = tbAddAuthor.Text,
                Category = tbAddCategory.Text,
                TotalOfPages = Convert.ToInt32(tbAddTotalOfPages.Text),
                CompletedPages = Convert.ToInt32(tbAddCompletedPages.Text),
            });

            DisplayBookCountsByCategory();
            MessageBox.Show("Book Added!");
            LoadLibrary();
            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Delete(new Libraries
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadLibrary();
            ClearTextBoxes();
        }


        private void CompleteBooksButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryManager.SearchCompletedBooks();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryManager.GetAll();
        }
    }
}

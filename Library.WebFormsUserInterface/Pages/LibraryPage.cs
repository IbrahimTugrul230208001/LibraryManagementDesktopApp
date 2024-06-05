using Library.Business.Concrete;
using Library.DataAccess.Abstract.EntityFramework;
using Library.DataAccess.Concrete.ADONET;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string _userName;
        public LibraryPage(string framework,string userName)
        {
            InitializeComponent();
            SelectFramework(framework,userName);
            _userName = userName;

        }

        public LibraryManager _libraryManager;

        private void LoadLibrary()
        {
            dataGridView1.DataSource = _libraryManager.GetAll();
            dataGridView1.Columns["UserName"].Visible = false;
            dataGridView1.Columns[1].Width = 34;
            dataGridView1.Columns[2].Width = 154;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 73;
            dataGridView1.Columns[5].Width = 93;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 70;
        }

        public void SelectFramework(string framework, string userName)
        {
            
            if (framework == "ADONET")
            {
                _libraryManager = new LibraryManager(new ADONET(userName));
            }
            else if (framework == "EntityFramework")
            {
                _libraryManager = new LibraryManager(new EntityFramework(userName));
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
            int completedPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            int totalOfPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            decimal completionRateDecimal = (decimal)completedPages / totalOfPages * 100;
            int completionRate = Convert.ToInt32(completionRateDecimal);
            circularProgressBar1.Value = completionRate;
            circularProgressBar1.Text = completionRateDecimal.ToString("0.00", CultureInfo.InvariantCulture);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            tbUpdateAuthor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            tbUpdateCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            tbUpdateCompletedPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            tbUpdateTotalOfPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            TbxUpdateStatus.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
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
            TbxAddStatus.Text = "";
            TbxUpdateStatus.Text = "";
        }
        private int _totalOfBooks;
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

            _totalOfBooks = totalBooks;
            Label totalLabel = new Label();
            totalLabel.Text = $"Total: {totalBooks} books";
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(10, yOffset);
            panelCategoryCounts.Controls.Add(totalLabel);
        }


        private void tbSearchByName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryManager.SearchBooksByName(tbSearchByName.Text);
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
                UserName = _userName,
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value),
                Name = tbUpdateName.Text,
                Author = tbUpdateAuthor.Text,
                Category = tbUpdateCategory.Text,
                CompletedPages = Convert.ToInt32(tbUpdateCompletedPages.Text),
                TotalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text),
                Status = TbxUpdateStatus.Text,
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
                UserName = _userName,
                Name = tbAddName.Text,
                Author = tbAddAuthor.Text,
                Category = tbAddCategory.Text,
                TotalOfPages = Convert.ToInt32(tbAddTotalOfPages.Text),
                CompletedPages = Convert.ToInt32(tbAddCompletedPages.Text),
                Status = TbxAddStatus.Text,
            });

            DisplayBookCountsByCategory();
            MessageBox.Show("Book Added!");
            LoadLibrary();
            ClearTextBoxes();
            SaveTotalOfBooksCount();
        }

        private void SaveTotalOfBooksCount()
        {
            SqlConnection connection = new SqlConnection("server = (localdb)\\mssqllocaldb;initial catalog = LibraryManagement;integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand($"UPDATE StoredUserData SET TotalOfBooksInLibrary = @TotalOfBooks WHERE UserName = @UserName",connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@TotalOfBooks",_totalOfBooks);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Delete(new Libraries
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value)
            });
            LoadLibrary();
            ClearTextBoxes();
            SaveTotalOfBooksCount();
            MessageBox.Show("The book has been deleted.");
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

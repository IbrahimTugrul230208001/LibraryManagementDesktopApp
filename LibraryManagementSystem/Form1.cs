using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {

        LibraryDal _libraryDal = new LibraryDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            DisplayBookCountsByCategory();

        }

        private void LoadBooks()
        {
            dataGridView1.DataSource = _libraryDal.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _libraryDal.Add(new Library
            {
                Name = tbAddName.Text,
                Author = tbAddAuthor.Text,
                Category = tbAddCategory.Text,
                TotalOfPages = Convert.ToInt32(tbAddTotalOfPages.Text),
                CompletedPages = Convert.ToInt32(tbAddCompletedPages.Text),
            });
            MessageBox.Show("Book Added!");
            LoadBooks();
            ClearTextBoxes();
            DisplayBookCountsByCategory();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            tbUpdateAuthor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            tbUpdateCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            tbUpdateCompletedPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            tbUpdateTotalOfPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _libraryDal.Update(new Library
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbUpdateName.Text,
                Author = tbUpdateAuthor.Text,
                Category = tbUpdateCategory.Text,
                CompletedPages = Convert.ToInt32(tbUpdateCompletedPages.Text),
                TotalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text)               
            });
            MessageBox.Show("Book has been Updated!");
            LoadBooks();
            DisplayBookCountsByCategory();
            ClearTextBoxes();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _libraryDal.Delete(ID);
            MessageBox.Show("Book has been Deleted!");
            LoadBooks();
            DisplayBookCountsByCategory();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            tbAddName.Text = "";
            tbAddAuthor.Text = "";
            tbAddCategory.Text = "";
            tbAddCompletedPages.Text = "";
            tbAddTotalOfPages.Text = "";
            tbUpdateName.Text = "";
            tbUpdateAuthor.Text = "";
            tbUpdateCategory.Text = "";
            tbUpdateCompletedPages.Text = "";
            tbUpdateTotalOfPages.Text = "";
        }

        private void tbSearchByName_TextChanged(object sender, EventArgs e)
        {
         dataGridView1.DataSource = _libraryDal.SearchBookByName(tbSearchByName.Text);
        }

        private void tbSearchByAuthor_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryDal.SearchBookByAuthor(tbSearchByAuthor.Text);
        }

        private void tbSearchByCategory_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _libraryDal.SearchBookByCategory(tbSearchByCategory.Text);
        }

        private void DisplayBookCountsByCategory()
        {
            Dictionary<string, int> categoryCounts;
            int totalBooks;
            categoryCounts = _libraryDal.CountBooksByCategory(out totalBooks);

            // Clear previous labels
            panelCategoryCounts.Controls.Clear();

            int yOffset = 10;
            foreach (var kvp in categoryCounts)
            {
                Label label = new Label();
                label.Text = $"{kvp.Key}: {kvp.Value} books";
                label.AutoSize = true;
                label.Location = new Point(10, yOffset);
                panelCategoryCounts.Controls.Add(label);

                yOffset += label.Height + 7; // Adjust spacing between labels
            }

            // Add label for total count
            Label totalLabel = new Label();
            totalLabel.Text = $"Total: {totalBooks} books";
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(10, yOffset);
            panelCategoryCounts.Controls.Add(totalLabel);
        }

    }
}

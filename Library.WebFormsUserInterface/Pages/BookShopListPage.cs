using CircularProgressBar;
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

namespace Library.WebFormsUserInterface
{
    public partial class BookShopListPage : UserControl
    {
        private string _framework;

        public BookShopListPage(string framework)
        {
            InitializeComponent();
            _framework = framework;
            SelectFramework(framework);

        }

        public LibraryManager _libraryManager;

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

        private void BookShopListPage_Load(object sender, EventArgs e)
        {
            LoadBookShopList();
            DisplayBookCountsByCategory();
            SetDataGridColumnWidths();
        }

        private void SetDataGridColumnWidths()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 85;
            dataGridView1.Columns[3].Width = 105;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[6].Width = 75;
        }

        private void LoadBookShopList()
        {
            dataGridView1.DataSource = _libraryManager.GetBookShopList();
        }

        private void DisplayBookCountsByCategory()
        {
            Dictionary<string, int> categoryCounts;
            int totalBooks;
            categoryCounts = _libraryManager.CountBooksByCategoryInBookShopList(out totalBooks);

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

            Label totalLabel = new Label();
            totalLabel.Text = $"Total: {totalBooks} books";
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(10, yOffset);
            panelCategoryCounts.Controls.Add(totalLabel);
        }
        private void ClearTextBoxes()
        {
            tbAddPrice.Text = "";
            tbAddAuthor.Text = "";
            tbAddCategory.Text = "";
            tbAddName.Text = "";
            tbAddTotalOfPages.Text = "";
            tbUpdateName.Text = "";
            tbUpdatePrice.Text = "";
            tbUpdateAuthor.Text = "";
            tbUpdateTotalOfPages.Text = "";
            tbUpdateCategory.Text = "";
            tbUpdateUserScore.Text = "";
            tbAddUserScore.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            tbUpdateAuthor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);               
            tbUpdateCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            tbUpdatePrice.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            tbUpdateTotalOfPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            tbUpdateUserScore.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            circularProgressBarUserScore.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            decimal userScoreOutOfFive = Convert.ToDecimal(Convert.ToDecimal(dataGridView1.CurrentRow.Cells[6].Value) / 20);
            circularProgressBarUserScore.Text = userScoreOutOfFive.ToString("0.00",CultureInfo.InvariantCulture);
        }

        private void AddLibraryButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Add(new Libraries
            {
                Name = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value),
                Author = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value),
                TotalOfPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value),
                Category = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value),
                CompletedPages = 0,
            });
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _libraryManager.AddToShopList(new BookShopList
            {
                Name = tbAddName.Text,
                Author = tbAddAuthor.Text,
                Category = tbAddCategory.Text,
                Price = Convert.ToDecimal(tbAddPrice.Text),
                TotalOfPages = Convert.ToInt32(tbAddTotalOfPages.Text),
                UserScore = Convert.ToDecimal(tbAddUserScore.Text),
            });
            MessageBox.Show("Book Added!");
            LoadBookShopList();
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _libraryManager.UpdateShopList(new BookShopList
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbUpdateName.Text,
                Author = tbUpdateAuthor.Text,
                Category = tbUpdateCategory.Text,
                TotalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text),
                Price = Convert.ToDecimal(tbUpdatePrice.Text),
                UserScore = Convert.ToDecimal(tbUpdateUserScore.Text),
            });
            MessageBox.Show("Book has been Updated!");
            LoadBookShopList();
            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _libraryManager.DeleteFromBookShopList(new BookShopList
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            MessageBox.Show("The Book Has Been Deleted!");
            LoadBookShopList();
        }
    }
}

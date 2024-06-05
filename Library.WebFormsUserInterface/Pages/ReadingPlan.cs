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
    public partial class ReadingPlan : UserControl
    {          
        public LibraryManager _libraryManager;
        private string _userName, _selectedBarColor;
        public ReadingPlan(string framework, string userName)
        {
            InitializeComponent();
            SelectFramework(framework,userName);
            _userName = userName;
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

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            string selectedColor = cbxSwitchColor.SelectedItem.ToString();

            if (selectedColor != _selectedBarColor)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("Update UserAccounts SET SelectedBarColor = @SelectedBarColor WHERE UserName = @UserName",connection);
                command.Parameters.AddWithValue("@UserName",_userName);
                command.Parameters.AddWithValue("@SelectedBarColor",selectedColor);
                command.ExecuteNonQuery();
                connection.Close();
                ColorSelection(selectedColor);
            }
        }

        private void ReadingPlan_Load(object sender, EventArgs e)
        {
            LoadSelectedBarColor();
            DisplayBookAndPageDataPanels();
            LoadPlannedBooksToRead();
            SetDataGridColumnWidth();
            SetBookAndPageLabelsData();
        }

        private void SetBookAndPageLabelsData()
        {
            List<Libraries> completedBooks = _libraryManager.SearchCompletedBooks();
            labelOfReadBooks.Text = Convert.ToString(completedBooks.Count());
            labelOfReadPages.Text = Convert.ToString(_libraryManager.GetTotalOfReadPages());
        }

        private void SetDataGridColumnWidth()
        {
            dataGridView1.Columns["UserName"].Visible = false;
            dataGridView1.Columns[1].Width = 32;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 85;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns["Status"].Visible = false;
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
            dataGridView1.DataSource = _libraryManager.GetCurrentlyReadingData();
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
            tbUpdateName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            tbUpdateAuthor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            tbUpdateCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            tbUpdateReadPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            tbUpdateTotalOfPages.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            int completedPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            int totalOfPages = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            decimal completionRateDecimal = (decimal)completedPages / totalOfPages * 100;
            int completionRate = Convert.ToInt32(completionRateDecimal);
            circularProgressBar1.Value = completionRate;
            circularProgressBar1.Text = completionRateDecimal.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Add(new Libraries
            {
                UserName = _userName,
                Name = tbAddName.Text,
                Author = tbAddAuthor.Text,
                Category = tbAddCategory.Text,
                CompletedPages = Convert.ToInt32(tbAddReadPages.Text),
                TotalOfPages = Convert.ToInt32(tbAddTotalOfPages.Text),
                Status = "Okuyor",
            });
            LoadPlannedBooksToRead();
            MessageBox.Show("Book Added!");
            ClearTextBoxes();
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
                TotalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text),
                CompletedPages = Convert.ToInt32(tbUpdateReadPages.Text),
                Status = "Okuyor",
            });
            int bookID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
           
                int completedPages = Convert.ToInt32(tbUpdateReadPages.Text);
                int totalOfPages = Convert.ToInt32(tbUpdateTotalOfPages.Text);
                decimal completionRateDecimal = (decimal)completedPages / totalOfPages * 100;
                int completionRateInt = (int)completionRateDecimal;
                circularProgressBar1.Value = completionRateInt;
                circularProgressBar1.Text = completionRateDecimal.ToString("0.00", CultureInfo.InvariantCulture);
               
            ClearTextBoxes();
            LoadPlannedBooksToRead();
            MessageBox.Show("The Book has Been Updated!");
        }

   
      

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _libraryManager.Delete(new Libraries
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value),
            });
            MessageBox.Show("Book has been Deleted!");
            LoadPlannedBooksToRead();
            ClearTextBoxes();
        }

       

        public string connectionString = "server = (localdb)\\mssqllocaldb;initial catalog=LibraryManagement;integrated security=True";
  
        private void LoadSelectedBarColor()
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select SelectedBarColor FROM UserAccounts WHERE UserName=@UserName", connection);
                command.Parameters.AddWithValue("UserName", _userName);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {                      
                  _selectedBarColor = Convert.ToString(reader["SelectedBarColor"]);                      
                }
                reader.Close();
                connection.Close();
            }
            ColorSelection(_selectedBarColor);
        }

        private void ColorSelection(string color)
        {
 
            switch (color.Trim())
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

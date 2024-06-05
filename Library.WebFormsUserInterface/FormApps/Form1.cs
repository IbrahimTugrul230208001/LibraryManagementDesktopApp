using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;
using Library.Business.Concrete;
using Library.DataAccess.Abstract;
using Library.DataAccess.Abstract.EntityFramework;
using Library.DataAccess.Concrete.ADONET;
using Library.DataAccess.Concrete.EntityFramework;
using Library.Entity.Concrete;
using Library.WebFormsUserInterface;
using Library.WebFormsUserInterface.FormApps;

namespace LibraryManagementSystem
{



    public partial class Form1 : Form
    {

        public LibraryManager _libraryManager;
        private string _framework;
        public string _userName;
        public void SelectFramework(string framework,string userName)
        {
            _framework = framework;
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

        public Form1(string framework,string userName)
        {
            InitializeComponent();
            SelectFramework(framework,userName);
            _userName = userName;
        }
                    
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

 
        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void LibraryButton_Click(object sender, EventArgs e)
        {
            LibraryButton.BackColor = Color.DimGray;
            LibraryPanelBack.BackColor = Color.White;
            SetShopPlanColorsToDefault();
            SetReadingPlanColorsToDefault();
            LibraryPanel.Controls.Clear();
            LibraryPage libraryPage = new LibraryPage(_framework,_userName);
            LibraryPanel.Controls.Add(libraryPage);

        }

        private void ShopPlanButton_Click(object sender, EventArgs e)
        {
            ShopPlanPanelBack.BackColor = Color.White;
            ShopPlanButton.BackColor = Color.DimGray;
            SetLibraryColorsToDefault();
            SetReadingPlanColorsToDefault();
            LibraryPanel.Controls.Clear();
            BookShopListPage bookShopListPage = new BookShopListPage(_framework,_userName);
            LibraryPanel.Controls.Add(bookShopListPage);

        }

        private void ReadingPlanButton_Click(object sender, EventArgs e)
        {
            ReadingPlanButton.BackColor = Color.DimGray;
            ReadingPlanPanelBack.BackColor = Color.White;
            SetLibraryColorsToDefault();
            SetShopPlanColorsToDefault();
            LibraryPanel.Controls.Clear();
            ReadingPlan readingPlanPage = new ReadingPlan(_framework,_userName);
            LibraryPanel.Controls.Add(readingPlanPage);
        }
        
        private void SetLibraryColorsToDefault()
        {
            LibraryButton.BackColor = Color.Black;
            LibraryPanelBack.BackColor = Color.Black;
        }

        private void SetShopPlanColorsToDefault()
        {
            ShopPlanButton.BackColor = Color.Black;
            ShopPlanPanelBack.BackColor = Color.Black;
        }

        private void SetReadingPlanColorsToDefault()
        {
            ReadingPlanButton.BackColor = Color.Black;
            ReadingPlanPanelBack.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetMainMenuData();
        }
        
        private void SetMainMenuData()
        {       
            SqlConnection connection = new SqlConnection("server = (localdb)\\mssqllocaldb;initial catalog = LibraryManagement;integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Id FROM Libraries WHERE UserName = @UserName",connection);
            command.Parameters.AddWithValue("UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            int totalOfBooksInLibrary = 0;
            while (reader.Read())
            {
                ++totalOfBooksInLibrary;               
            }
            reader.Close();
            connection.Close();       
            BookCountLabel.Text = totalOfBooksInLibrary.ToString();   
            HelloLabel.Text += _userName + "!";
        }
    }
}
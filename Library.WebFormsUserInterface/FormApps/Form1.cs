using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using Library.Entity.Concrete;
using Library.WebFormsUserInterface;
using Library.WebFormsUserInterface.FormApps;


namespace LibraryManagementSystem
{



    public partial class Form1 : Form
    {

        public LibraryManager _libraryManager;
        private string _framework;
        private string _userName;
        public void SelectFramework(string framework)
        {
            _framework = framework;
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

        public Form1(string framework,string userName)
        {
            InitializeComponent();
            SelectFramework(framework);
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
            LibraryButton.Font = new Font(LibraryButton.Font, FontStyle.Underline);
            ShopPlanButton.Font = new Font(ShopPlanButton.Font, FontStyle.Regular);
            ReadingPlanButton.Font = new Font(ReadingPlanButton.Font, FontStyle.Regular);

            LibraryPanel.Controls.Clear();
            LibraryPage libraryPage = new LibraryPage(_framework);
            LibraryPanel.Controls.Add(libraryPage);
        }

        private void ShopPlanButton_Click(object sender, EventArgs e)
        {
            LibraryButton.Font = new Font(LibraryButton.Font, FontStyle.Regular);
            ShopPlanButton.Font = new Font(ShopPlanButton.Font, FontStyle.Underline);
            ReadingPlanButton.Font = new Font(ReadingPlanButton.Font, FontStyle.Regular);

            LibraryPanel.Controls.Clear();
            BookShopListPage bookShopListPage = new BookShopListPage(_framework);
            LibraryPanel.Controls.Add(bookShopListPage);
        }

        private void ReadingPlanButton_Click(object sender, EventArgs e)
        {
            LibraryButton.Font = new Font(LibraryButton.Font, FontStyle.Regular);
            ShopPlanButton.Font = new Font(ShopPlanButton.Font, FontStyle.Regular);
            ReadingPlanButton.Font = new Font(ReadingPlanButton.Font, FontStyle.Underline);

            LibraryPanel.Controls.Clear();
            ReadingPlan readingPlan = new ReadingPlan(_framework);
            LibraryPanel.Controls.Add(readingPlan);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetMainMenuData();
        }

        private void SetMainMenuData()
        {
            progressBarCompletionRate.Value = (int)Library.WebFormsUserInterface.Properties.Settings.Default.SelectedCompletionRate;
            HelloLabel.Text += _userName + "!";
            NameOfBookLabel.Text += Library.WebFormsUserInterface.Properties.Settings.Default.SelectedBookName;
            AuthorOfBookLabel.Text += Library.WebFormsUserInterface.Properties.Settings.Default.AuthorOfSelectedBook;
            CategoryOfBookLabel.Text += Library.WebFormsUserInterface.Properties.Settings.Default.CategoryOfSelectedBook;
            BookCountLabel.Text = Convert.ToString(Library.WebFormsUserInterface.Properties.Settings.Default.TotalOfBooks);
        }

        
    }

}
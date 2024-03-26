using Library.Business.Concrete;
using Library.DataAccess.Abstract.EntityFramework;
using Library.DataAccess.Concrete.ADONET;
using Library.Entity.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.WebFormsUserInterface.FormApps
{
    public partial class RegisterForms : Form
    {
        private LibraryManager _libraryManager;
       
        public RegisterForms()
        {
            _libraryManager = new LibraryManager(new ADONET());
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (TbxPassword.Text == TbxConfirmPassword.Text)
            {
                _libraryManager.AddNewUser(new UserAccount
                {
                    UserName = TbxUserName.Text,
                    Password = TbxPassword.Text,
                });
                ClearTextBoxes();
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Password confirmation is not valid. Check your password again.");
            }
        }

        private void ClearTextBoxes()
        {
            TbxUserName.Text = "";
            TbxPassword.Text = "";
            TbxConfirmPassword.Text = "";
        }

        private void checkBoxConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConfirmPassword.Checked)
            {
                TbxConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TbxConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                TbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void RegisterForms_Load(object sender, EventArgs e)
        {
            TbxPassword.UseSystemPasswordChar = true;
            TbxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void UpPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void UpPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}

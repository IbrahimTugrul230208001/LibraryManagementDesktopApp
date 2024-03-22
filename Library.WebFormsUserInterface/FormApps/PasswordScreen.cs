using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Library.WebFormsUserInterface;
using System.Runtime.Versioning;
using System.Reflection;

namespace LibraryManagementSystem
{
    public partial class PasswordScreen : Form
    {
        public string Framework;
        public string _userName;
        public PasswordScreen()
        {
            InitializeComponent();
           
        }
       
        
        private void PasswordScreen_Load(object sender, EventArgs e)
        {       
            TbxPassword.UseSystemPasswordChar = true;
            MessageBox.Show("Username: Ibrahim, Password: 123456");
        }

      
      
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string password = "123456";
            string userName = "Ibrahim";

            if (userName == TbxUserName.Text && password == TbxPassword.Text)
            {
                _userName = userName;
                if (ADONETradioButton.Checked)
                {
                    Framework = "ADONET";
                    this.Dispose();
                    
                }
                else if (EfRadioButton.Checked)
                {
                    Framework = "EntityFramework";
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Select a Framework.");
                    return;
                }             
            }

            else
            {
                MessageBox.Show("Wrong Password or Username.\n Username: Ibrahim, Password: 123456");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                TbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void ADONETradioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (EfRadioButton.Checked)
            {
                ADONETradioButton.Checked = false;
            }
        }

        private void EfRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ADONETradioButton.Checked)
            {
                EfRadioButton.Checked = false;
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, 
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

       
    }
}

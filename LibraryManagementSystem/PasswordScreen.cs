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

namespace LibraryManagementSystem
{
    public partial class PasswordScreen : Form
    {
        public PasswordScreen()
        {
            InitializeComponent();
        }

       
        private void PasswordScreen_Load(object sender, EventArgs e)
        {
            TbxPassword.UseSystemPasswordChar = true;

        }
         private void LoginButton_Click(object sender, EventArgs e)
        {
            string password = "123456";
            string userName = "ibrahim";           
                
                if (userName == TbxUserName.Text && password == TbxPassword.Text)
                {
                    Form1 form1 = new Form1();
                    form1.FormClosed += (s, args) => Application.Exit(); // Handle FormClosed event
                    form1.Show();
                    // Hide the current instance of the login form
                    this.Hide();
                    return;
                }
                else if (userName == TbxUserName.Text && password != TbxPassword.Text)
                {
                    WarningLabel.Text = "Wrong Password. Try again!";
                }
                else if (userName != TbxUserName.Text && password == TbxPassword.Text)
                {
                    WarningLabel.Text = "Wrong Username. Try again!";
                }
                else
                {
                    WarningLabel.Text = "Wrong Username and Password. Try again!";
                }

            
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            // Check if the checkbox is checked
            if (checkBox1.Checked)
            {
                TbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Show the original password
                TbxPassword.UseSystemPasswordChar = true;
            }


        }

      
    }
}

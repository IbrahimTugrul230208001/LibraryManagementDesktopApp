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
using Library.Entity.Concrete;
using System.Data.SqlClient;
using Library.WebFormsUserInterface.FormApps;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            MessageBox.Show("Username: ibrahim, Password: 123456");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string password = TbxPassword.Text;
            string userName = TbxUserName.Text;

            if (ValidateUser(userName, password) == true)
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
        public bool ValidateUser(string username, string password)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;integrated security=True";
            string query = "SELECT Username, Password FROM UserAccounts";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string storedUsername = reader["Username"].ToString();
                    string storedPassword = reader["Password"].ToString();

                    if (username == storedUsername && password == storedPassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ADONETradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EfRadioButton.Checked)
            {
                ADONETradioButton.Checked = false;
            }
        }

        private void EfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ADONETradioButton.Checked)
            {
                EfRadioButton.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegisterForms registerForm = new RegisterForms();
            registerForm.Show();
        }

        private void ForgotYourPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: ibrahim, Password: 123456");
        }
    }
}

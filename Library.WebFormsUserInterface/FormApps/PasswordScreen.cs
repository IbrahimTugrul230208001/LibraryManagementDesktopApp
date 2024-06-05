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
using Library.Business.Concrete;
using Library.DataAccess.Concrete.ADONET;
using Library.DataAccess.Abstract.EntityFramework;
using System.Security.Cryptography;

namespace LibraryManagementSystem
{
    public partial class PasswordScreen : Form
    {
        public string _framework;
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
            string username = TbxUserName.Text;
            string password = TbxPassword.Text;

            if (ValidateUser(username, password))
            {
                _userName = username;
                MessageBox.Show("Login successful!");
                _framework = "EntityFramework";
                this.Dispose();
    
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;integrated security=True";
            string query = "SELECT PasswordHash FROM UserAccounts WHERE Username = @Username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHashedPassword = reader["PasswordHash"].ToString();
                        return VerifyHashedPassword(password, storedHashedPassword);
                    }
                }
            }
            return false;
        }

        private bool VerifyHashedPassword(string password, string hashedPassword)
        {
            // You should implement your hashing algorithm and comparison logic here
            // For example, using SHA256:
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string inputHashedPassword = Convert.ToBase64String(hashBytes);
                return inputHashedPassword == hashedPassword;
            }
        }




        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
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

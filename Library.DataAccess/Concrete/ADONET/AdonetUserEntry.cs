using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.ADONET
{
    public class AdonetUserEntry
    {
        SqlConnection _connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;integrated security=True");

        public void AddNewUser(UserAccount userAccount)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert INTO UserAccounts Values (@UserName,@Password)", _connection);
            command.Parameters.AddWithValue("@UserName", userAccount.UserName);
            command.Parameters.AddWithValue("@Password", userAccount.Password);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}

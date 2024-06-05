using Library.DataAccess.Concrete.EntityFramework;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.ADONET
{
    public class UserRegisteration
    {
        SqlConnection _connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;integrated security=True");
        public async void AddNewUser(UserAccount userAccount)
        {
            using (var context = new LibraryContext())
            {
                context.UserAccounts.Add(userAccount);
                await context.SaveChangesAsync();
            }
        }
          private void ConnectionControl()
          {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
          }
     
           public void AddNewDynamicUserContent(string userName)
           {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO StoredUserData VALUES(@UserName,@SelectedBarColor,@TotalOfBooksInLibrary)",_connection);
            command.Parameters.AddWithValue("@UserName",userName);
            command.Parameters.AddWithValue("@SelectedBarColor","Black");
            command.Parameters.AddWithValue("@TotalOfBooksInLibrary", 0);
           }
 

    }
}

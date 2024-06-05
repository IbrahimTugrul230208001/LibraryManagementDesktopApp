using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Abstract;
using Library.Entity.Concrete;



namespace Library.DataAccess.Concrete.ADONET
{
    public class ADONET : ILibraryDal
    {
        private string _userName;
        public int totalOfReadPages;
        public ADONET(string userName)
        {
            _userName = userName;
        }

        SqlConnection _connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=LibraryManagement;integrated security=True");
        public List<Libraries> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT Id,Name,Author,Category,completedPages,totalOfPages,Status FROM Libraries WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            List<Libraries> libraries = new List<Libraries>();

            while (reader.Read())
            {

                Libraries library = new Libraries()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Author = reader["Author"].ToString(),
                    Category = reader["Category"].ToString(),
                    CompletedPages = Convert.ToInt32(reader["CompletedPages"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalofPages"]),
                    Status = Convert.ToString(reader["Status"])
                };
                libraries.Add(library);
            }
            reader.Close();
            _connection.Close();
            return libraries;
        }

        public int GetTotalOfReadPages()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT completedPages FROM Libraries WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            totalOfReadPages = 0;
            while (reader.Read())
            {
                totalOfReadPages += Convert.ToInt32(reader["completedPages"]);            
            }
            reader.Close();
            _connection.Close();
            return totalOfReadPages;
        }
       
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Libraries library)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Insert into Libraries VALUES(@UserName,@Name,@Author,@Category,@CompletedPages,@TotalOfPages,@Status)", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Name", library.Name);
            command.Parameters.AddWithValue("@Author", library.Author);
            command.Parameters.AddWithValue("@Category", library.Category);
            command.Parameters.AddWithValue("@CompletedPages", library.CompletedPages);
            command.Parameters.AddWithValue("@TotalofPages", library.TotalOfPages);
            command.Parameters.AddWithValue("@Status", library.Status);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Libraries library)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Libraries Set UserName = @UserName, Name=@Name,Author=@Author,Category=@Category,CompletedPages=@CompletedPages,TotalOfPages=@TotalofPages,Status=@Status where Id = @Id", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Id", library.Id);
            command.Parameters.AddWithValue("@Name", library.Name);
            command.Parameters.AddWithValue("@Author", library.Author);
            command.Parameters.AddWithValue("@Category", library.Category);
            command.Parameters.AddWithValue("@CompletedPages", library.CompletedPages);
            command.Parameters.AddWithValue("@TotalofPages", library.TotalOfPages);
            command.Parameters.AddWithValue("@Status", library.Status);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(Libraries library)
        {
            int Id = library.Id;
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Libraries where Id=@Id AND UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Libraries> SearchBooksByName(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Select * from Libraries WHERE Name LIKE '%' + @Key + '%' AND UserName = @UserName ", _connection); // Associate the SqlCommand with the SqlConnection
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Key", key);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            List<Libraries> list = new List<Libraries>();

            while (reader.Read())
            {

                Libraries library = new Libraries()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    CompletedPages = Convert.ToInt32(reader["CompletedPages"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"])
                };
                list.Add(library);
            }
            reader.Close();
            _connection.Close();
            return list;
        }

        public List<Libraries> SearchBooksByAuthor(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Select * from Libraries WHERE Author LIKE '%' + @Key + '%' AND UserName = @UserName ", _connection); // Associate the SqlCommand with the SqlConnection
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Key", key);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            List<Libraries> list = new List<Libraries>();

            while (reader.Read())
            {

                Libraries library = new Libraries()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    CompletedPages = Convert.ToInt32(reader["CompletedPages"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"])

                };
                list.Add(library);
            }
            reader.Close();
            _connection.Close();
            return list;
        }

        public List<Libraries> SearchBooksByCategory(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Select * from Libraries WHERE Category LIKE '%' + @Key + '%' AND UserName = @UserName", _connection); // Associate the SqlCommand with the SqlConnection
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Key", key);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            List<Libraries> list = new List<Libraries>();

            while (reader.Read())
            {

                Libraries library = new Libraries()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    CompletedPages = Convert.ToInt32(reader["CompletedPages"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"])

                };
                list.Add(library);
            }
            reader.Close();
            _connection.Close();
            return list;
        }

        public Dictionary<string, int> CountBooksByCategory(out int totalBooks)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"SELECT Category, COUNT(*) AS Count FROM Libraries WHERE UserName = @UserName GROUP BY Category", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();
            totalBooks = 0;

            while (reader.Read())
            {
                string category = Convert.ToString(reader["Category"]);
                int count = Convert.ToInt32(reader["Count"]);
                categoryCounts.Add(category, count);
                totalBooks += count; // Add to total count
            }

            reader.Close();
            _connection.Close();
            return categoryCounts;
        }

        public List<Libraries> SearchCompletedBooks()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT Id, Name, Author, Category, CompletedPages, TotalOfPages," +
                " (CONVERT(decimal(5, 2), CompletedPages) / NULLIF(TotalofPages, 0)) * 100 AS [CompletionRate],Status FROM Libraries WHERE (CONVERT(decimal(5, 2), CompletedPages) / NULLIF(TotalofPages, 0)) * 100 = 100 AND UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            List<Libraries> list = new List<Libraries>();

            while (reader.Read())
            {
                Libraries library = new Libraries()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    CompletedPages = Convert.ToInt32(reader["CompletedPages"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"]),
                    Status = Convert.ToString(reader["Status"])
                };
                list.Add(library);
            }

            reader.Close();
            _connection.Close();
            return list;
        }

        //BookShopList

        public List<BookShopList> GetBookShopList()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"SELECT Id, Name, Author, Category, Price, TotalOfPages,UserScore FROM BookShopLists WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            List<BookShopList> bookShopList = new List<BookShopList>();

            while (reader.Read())
            {
                BookShopList list = new BookShopList()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Author = reader["Author"].ToString(),
                    Category = reader["Category"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"]),
                    UserScore = Convert.ToDecimal(reader["UserScore"])
                };
                bookShopList.Add(list);
            }
            reader.Close();
            _connection.Close();
            return bookShopList;
        }

        public void UpdateShopList(BookShopList bookShopList)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update BookShopLists Set Name=@Name,Author=@Author,Category=@Category,Price=@Price, TotalOfPages = @TotalOfPages, UserScore = @UserScore WHERE Id = @Id AND UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Id", bookShopList.Id);
            command.Parameters.AddWithValue("@Name", bookShopList.Name);
            command.Parameters.AddWithValue("@Author", bookShopList.Author);
            command.Parameters.AddWithValue("@Category", bookShopList.Category);
            command.Parameters.AddWithValue("@Price", bookShopList.Price);
            command.Parameters.AddWithValue("@TotalOfPages", bookShopList.TotalOfPages);
            command.Parameters.AddWithValue("@UserScore", bookShopList.UserScore);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void AddToShopList(BookShopList bookShopList)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert INTO BookShopLists Values(@UserName,@Name,@Author,@Category,@Price,@TotalOfPages,@UserScore)", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Name", bookShopList.Name);
            command.Parameters.AddWithValue("@Author", bookShopList.Author);
            command.Parameters.AddWithValue("@Category", bookShopList.Category);
            command.Parameters.AddWithValue("@Price", bookShopList.Price);
            command.Parameters.AddWithValue("@TotalOfPages", bookShopList.TotalOfPages);
            command.Parameters.AddWithValue("@UserScore", bookShopList.UserScore);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteFromShopList(BookShopList bookShopList)
        {
            int ID = bookShopList.Id;
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from BookShopLists where Id=@Id WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Id", ID);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<BookShopList> SearchInBookShopListByName(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Select * from Bookshoplists WHERE Name LIKE '%' + @Key + '%' AND WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@Key", key);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            List<BookShopList> list = new List<BookShopList>();

            while (reader.Read())
            {
                BookShopList booklist = new  BookShopList()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"]),
                    UserScore = Convert.ToDecimal(reader["UserScore"])

                };
                list.Add(booklist);
            }
            reader.Close();
            _connection.Close();
            return list;
        }

        public List<BookShopList> SearchInBookShopListByAuthor(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Select * from Bookshoplists WHERE Author LIKE '%' + @Key + '%' AND WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@Key", key);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            List<BookShopList> list = new List<BookShopList>();
            while (reader.Read())
            {
                BookShopList booklist = new BookShopList()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"]),
                    UserScore = Convert.ToDecimal(reader["UserScore"])
                };

                list.Add(booklist);
            }
            reader.Close();
            _connection.Close();
            return list;
        }

        public List<BookShopList> SearchInBookShopListByCategory(string key)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"Select * from BookShopLists WHERE Cateogry LIKE '%' + @Key + '%' AND WHERE UserName = @UserName", _connection);
            command.Parameters.AddWithValue("@Key", key);
            command.ExecuteNonQuery();
            List<BookShopList> list = new List<BookShopList>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                BookShopList booklist = new BookShopList()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Category = Convert.ToString(reader["Category"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalOfPages"]),
                    UserScore = Convert.ToDecimal(reader["UserScore"])
                };

                list.Add(booklist);

            }
            reader.Close();
            _connection.Close();
            return list;
        }

        public Dictionary<string, int> CountBooksByCategoryInBookShopList(out int totalBooks)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand($"SELECT Category, COUNT(*) AS Count FROM BookShopLists WHERE UserName = @UserName GROUP BY Category", _connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();
            totalBooks = 0;
            while (reader.Read())
            {
                string category = Convert.ToString(reader["Category"]);
                int count = Convert.ToInt32(reader["Count"]);
                categoryCounts.Add(category, count);
                totalBooks += count; 
            }
            reader.Close();
            _connection.Close();
            return categoryCounts;
        }

        public List<Libraries> GetCurrentlyReadingData()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select Id,Name,Author,Category,CompletedPages,TotalOfPages FROM Libraries WHERE UserName = @UserName AND Status = @Status",_connection);
            command.Parameters.AddWithValue("UserName",_userName);
            command.Parameters.AddWithValue("Status","Okuyor");
            SqlDataReader reader = command.ExecuteReader();
            List<Libraries> booksOnReadingStatus = new List<Libraries>();
            while (reader.Read())
            {

                Libraries libraryOnRead = new Libraries()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Author = reader["Author"].ToString(),
                    Category = reader["Category"].ToString(),
                    CompletedPages = Convert.ToInt32(reader["CompletedPages"]),
                    TotalOfPages = Convert.ToInt32(reader["TotalofPages"]),
                };
                booksOnReadingStatus.Add(libraryOnRead);
            }
            reader.Close();
            _connection.Close();
            return booksOnReadingStatus;
        }
    }
}

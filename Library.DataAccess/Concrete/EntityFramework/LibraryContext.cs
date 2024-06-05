using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntityFramework
{
    public class LibraryContext:DbContext
    {
        public DbSet<Libraries> Libraries { get; set; }
        public DbSet<BookShopList> BookShopLists { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}

using Library.DataAccess.Concrete.EntityFramework;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Abstract.EntityFramework
{
    public class EntityFramework : ILibraryDal
    {
        private string _userName;
        public EntityFramework(string userName)
        {
            _userName = userName;
        }

        public List<Libraries> GetAll()
        {

            using (LibraryContext context = new LibraryContext())
            {
                return context.Libraries.Where(p => p.UserName == _userName).ToList();
            }
        }

        public void Add(Libraries library)
        {
            using(LibraryContext context = new LibraryContext())
            {
                context.Libraries.Add(library);
                context.SaveChanges();
            }
        }

        public void AddToShopList(BookShopList bookShopList)
        {
            using(LibraryContext context = new LibraryContext())
            {
                context.BookShopLists.Add(bookShopList);
                context.SaveChanges();
            }
        }

        public Dictionary<string, int> CountBooksByCategory(out int totalBooks)
        {
            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();

            using (LibraryContext context = new LibraryContext())
            {
                var booksByCategory = context.Libraries.Where(p=>p.UserName == _userName).GroupBy(l => l.Category)
                                                      .Select(g => new
                                                      {
                                                          Category = g.Key,
                                                          Count = g.Count()
                                                      }).ToList();

                totalBooks = booksByCategory.Sum(c => c.Count);

                foreach (var category in booksByCategory)
                {
                    categoryCounts.Add(category.Category, category.Count);
                }
            }

            return categoryCounts;
        }

       public void Delete(Libraries library)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(library);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

      

        public List<BookShopList> GetBookShopList()
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.BookShopLists.Where(p=>p.UserName == _userName).ToList();
            }
        }

        public List<Libraries> SearchBookByCategory(string key)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Libraries.Where(p=>p.Category.Contains(key)).ToList();
            }
        }

        public List<Libraries> SearchBookByName(string key)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Libraries.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Libraries> SearchBooksByAuthor(string key)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Libraries.Where(p => p.Author.Contains(key)).ToList();
            }
        }

        public List<Libraries> SearchCompletedBooks()
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Libraries
                    .Where(book => book.TotalOfPages != 0 && Math.Round((decimal)book.CompletedPages / book.TotalOfPages * 100, 2) == 100)
                    .Where(p=>p.UserName == _userName)
                    .ToList();
            }
        }


        public void Update(Libraries library)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(library);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void UpdateShopList(BookShopList bookShopList)
        {
            using(LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(bookShopList);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteFromShopList(BookShopList bookShopList)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(bookShopList);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<BookShopList> SearchInBookShopListByName(string key)
        {
            using(LibraryContext context = new LibraryContext())
            {
                return context.BookShopLists.Where(p=>p.Name.Contains(key)).Where(p=>p.UserName == _userName).ToList();
            }
        }

        public List<BookShopList> SearchInBookShopListByAuthor(string key)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.BookShopLists.Where(p => p.Author.Contains(key)).Where(p => p.UserName == _userName).ToList();
            }
        }

        public List<BookShopList> SearchInBookShopListByCategory(string key)
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.BookShopLists.Where(p => p.Category.Contains(key)).Where(p => p.UserName == _userName).ToList();
            }
        }

        public Dictionary<string, int> CountBooksByCategoryInBookShopList(out int totalBooks)
        {

            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();
            totalBooks = 0;

            using (var dbContext = new LibraryContext())
            {
                var counts = dbContext.BookShopLists.Where(p => p.UserName == _userName)
                    .GroupBy(b => b.Category).Select(g => new { Category = g.Key, Count = g.Count() }).ToList();
                foreach (var item in counts)
                {
                    categoryCounts.Add(item.Category, item.Count);
                    totalBooks += item.Count;
                }
            }

            return categoryCounts;
        }

        public List<UserReadingPlan> GetPlannedBooks()
        {
            using(LibraryContext context = new LibraryContext())
            {
                return context.ReadingPlan.ToList();
            }
        }

        public void AddBookToPlannedBooksList(UserReadingPlan plannedBook)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.ReadingPlan.Add(plannedBook);
                context.SaveChanges();
            }
        }

        public void UpdatePlannedBookList(UserReadingPlan plannedBook)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(plannedBook);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePlannedBookList(UserReadingPlan plannedBook)
        {

            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(plannedBook);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        
    }
}

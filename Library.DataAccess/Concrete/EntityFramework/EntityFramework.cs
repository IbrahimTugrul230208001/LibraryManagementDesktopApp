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
            using (var context = new LibraryContext())
            {
                return context.Libraries.Where(p => p.UserName == _userName).ToList();
            }
        }

        public int GetTotalOfReadPages()
        {
            int totalOfReadPages = 0;
            try
            {
                using (var context = new LibraryContext())
                {
                    totalOfReadPages = context.Libraries
                        .Where(l => l.UserName == _userName)
                        .Sum(l => l.CompletedPages);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return totalOfReadPages;
        }

        public async void Add(Libraries library)
        {
            using(var context = new LibraryContext())
            {
                context.Libraries.Add(library);
                await context.SaveChangesAsync();
            }
        }
        public async void Update(Libraries library)
        {
            using (var context = new LibraryContext())
            {
                context.Entry(library).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async void Delete(Libraries library)
        {
            using (var context = new LibraryContext())
            {
                context.Entry(library).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async void AddToShopList(BookShopList bookShopList)
        {
            using(var context = new LibraryContext())
            {
                context.BookShopLists.Add(bookShopList);
                await context.SaveChangesAsync();
            }
        }

        public Dictionary<string, int> CountBooksByCategory(out int totalBooks)
        {
            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();

            using (var context = new LibraryContext())
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


 
        public List<BookShopList> GetBookShopList()
        {
            using (var context = new LibraryContext())
            {
                return context.BookShopLists.Where(p=>p.UserName == _userName).ToList();
            }
        }

        public List<Libraries> SearchBooksByCategory(string key)
        {
            using (var context = new LibraryContext())
            {
                return context.Libraries.Where(p=>p.Category.Contains(key)).ToList();
            }
        }

        public List<Libraries> SearchBooksByName(string key)
        {
            using (var context = new LibraryContext())
            {
                return context.Libraries.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Libraries> SearchBooksByAuthor(string key)
        {
            using (var context = new LibraryContext())
            {
                return context.Libraries.Where(p => p.Author.Contains(key)).ToList();
            }
        }

        public List<Libraries> SearchCompletedBooks()
        {
            using (var context = new LibraryContext())
            {
                return context.Libraries
                    .Where(book => book.TotalOfPages != 0 &&
                    Math.Round((decimal)book.CompletedPages / book.TotalOfPages * 100, 2) == 100 && book.UserName == _userName)
                    .ToList();
            }
        }


    

        public async void UpdateShopList(BookShopList bookShopList)
        {
            using(var context = new LibraryContext())
            {
                context.Entry(bookShopList).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async void DeleteFromShopList(BookShopList bookShopList)
        {
            using (var context = new LibraryContext())
            {
                context.Entry(bookShopList).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public List<BookShopList> SearchInBookShopListByName(string key)
        {
            using(var context = new LibraryContext())
            {
                return context.BookShopLists.Where(p => p.Name.Contains(key) && p.UserName == _userName).ToList();
            }
        }

        public List<BookShopList> SearchInBookShopListByAuthor(string key)
        {
            using (var context = new LibraryContext())
            {
                return context.BookShopLists.Where(p => p.Author.Contains(key) && p.UserName == _userName).ToList();
            }
        }


        public List<BookShopList> SearchInBookShopListByCategory(string key)
        {
            using (var context = new LibraryContext())
            {
                return context.BookShopLists.Where(p => p.Category.Contains(key) && p.UserName == _userName).ToList();
            }
        }

        public Dictionary<string, int> CountBooksByCategoryInBookShopList(out int totalBooks)
        {
            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();
            totalBooks = 0;

            using (var context = new LibraryContext())
            {
                var counts = context.BookShopLists.Where(p => p.UserName == _userName)
                    .GroupBy(b => b.Category).Select(g => new { Category = g.Key, Count = g.Count() }).ToList();
                foreach (var item in counts)
                {
                    categoryCounts.Add(item.Category, item.Count);
                    totalBooks += item.Count;
                }
            }

            return categoryCounts;
        }

        public List<Libraries> GetCurrentlyReadingData()
        {
            using(var context = new LibraryContext())
            {
               return context.Libraries.Where(p=>p.UserName == _userName && p.Status == "Okuyor").ToList();
            }
        }
    }
}

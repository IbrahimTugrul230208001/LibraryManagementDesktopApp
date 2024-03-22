using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Library.DataAccess.Abstract
{ 
    public interface ILibraryDal
    {
        List<Libraries> GetAll();
        void Add(Libraries library);
        void Update(Libraries library);
        void Delete(Libraries library);    
        List<BookShopList> GetBookShopList();
        void UpdateShopList(BookShopList bookShopList);
        void AddToShopList(BookShopList bookShopList);
        void DeleteFromShopList(BookShopList bookShopList);
        List<Libraries> SearchBookByName(string key);
        List<Libraries> SearchBooksByAuthor(string key);
        List<Libraries> SearchBookByCategory(string key);
        Dictionary<string, int> CountBooksByCategory(out int totalBooks);
        List<Libraries> SearchCompletedBooks();
        List<BookShopList> SearchInBookShopListByName(string key);
        List<BookShopList> SearchInBookShopListByAuthor(string key);
        List<BookShopList> SearchInBookShopListByCategory(string key);
        Dictionary<string, int> CountBooksByCategoryInBookShopList(out int totalBooks);
        List<PlannedBook> GetPlannedBooks();
        void AddBookToPlannedBooksList(PlannedBook plannedBook);
        void UpdatePlannedBookList(PlannedBook plannedBook);
        void DeletePlannedBookList(PlannedBook plannedBook);
    }
}

using FluentValidation;
using Library.Business.FluentValidation;
using Library.DataAccess.Abstract;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete
{
    public class LibraryManager
    {
        private ILibraryDal _LibraryDal;
 
        public LibraryManager(ILibraryDal LibraryDal)
        {
            _LibraryDal = LibraryDal;
        }

        public List<Libraries> GetAll()
        {
            return _LibraryDal.GetAll();
        }
        
        public void Add(Libraries library)
        {
            LibraryValidator validator = new LibraryValidator();
            var result = validator.Validate(library);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _LibraryDal.Add(library);
        }

        public void Update(Libraries library)
        {
            LibraryValidator validator = new LibraryValidator();
            var result = validator.Validate(library);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _LibraryDal.Update(library);
        }


        public void Delete(Libraries library)
        {
            _LibraryDal.Delete(library);
        }


        public List<BookShopList> GetBookShopList()
        {
            return _LibraryDal.GetBookShopList();
        }

        public void AddToShopList(BookShopList bookShopList)
        {
            BookShopListValidator validator = new BookShopListValidator();
            var result = validator.Validate(bookShopList);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _LibraryDal.AddToShopList(bookShopList);
        }

        public void UpdateShopList(BookShopList bookShopList)
        {
            BookShopListValidator validator = new BookShopListValidator();
            var result = validator.Validate(bookShopList);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _LibraryDal.UpdateShopList(bookShopList);
        }

       

        public List<Libraries> SearchBookByName(string key)
        {
            return _LibraryDal.SearchBookByName(key);
        }

        public Dictionary<string, int> CountBooksByCategory(out int totalBooks)
        {
            return _LibraryDal.CountBooksByCategory(out totalBooks);
        }

        public List<Libraries> SearchCompletedBooks()
        {
            return _LibraryDal.SearchCompletedBooks();
        }

        public List<Libraries> SearchBooksByAuthor(string key)
        {
            return _LibraryDal.SearchBooksByAuthor(key);
        }

        public List<Libraries> SearchBooksByCategory(string key)
        {
            return _LibraryDal.SearchBookByCategory(key);
        }
        
        public void DeleteFromBookShopList(BookShopList bookShopList)
        {
           
            _LibraryDal.DeleteFromShopList(bookShopList);
        }

        public Dictionary<string, int> CountBooksByCategoryInBookShopList(out int totalBooks)
        {
            return _LibraryDal.CountBooksByCategoryInBookShopList(out totalBooks);
        }

        public List<PlannedBook> GetPlannedBooksToRead()
        {
            
            return _LibraryDal.GetPlannedBooks();
        }

        public void AddToBookPlanList(PlannedBook plannedBook)
        {
            PlannedBooksValidator validator = new PlannedBooksValidator();
            var result = validator.Validate(plannedBook);
            if(result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _LibraryDal.AddBookToPlannedBooksList(plannedBook);
        }
        
        public void UpdateBookPlanList(PlannedBook plannedBook)
        {
            PlannedBooksValidator validator = new PlannedBooksValidator();
            var result = validator.Validate(plannedBook);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _LibraryDal.UpdatePlannedBookList(plannedBook);
        }

        public void DeleteBookPlanList(PlannedBook plannedBook)
        {
         
            _LibraryDal.DeletePlannedBookList(plannedBook);
        }

    }
}

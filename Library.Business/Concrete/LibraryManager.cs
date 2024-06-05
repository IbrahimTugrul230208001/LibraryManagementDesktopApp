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
    public class LibraryManager:ILibraryDal
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



            public List<Libraries> SearchBooksByName(string key)
            {
                return _LibraryDal.SearchBooksByName(key);
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
                return _LibraryDal.SearchBooksByCategory(key);
            }

            public void DeleteFromBookShopList(BookShopList bookShopList)
            {

                _LibraryDal.DeleteFromShopList(bookShopList);
            }

            public Dictionary<string, int> CountBooksByCategoryInBookShopList(out int totalBooks)
            {
                return _LibraryDal.CountBooksByCategoryInBookShopList(out totalBooks);
            }

            public int GetTotalOfReadPages()
            {
              return _LibraryDal.GetTotalOfReadPages();
            }

            public List<Libraries> GetCurrentlyReadingData()
            {
            return _LibraryDal.GetCurrentlyReadingData();
            }

        public void DeleteFromShopList(BookShopList bookShopList)
        {
            _LibraryDal.DeleteFromShopList(bookShopList);
        }


        public List<BookShopList> SearchInBookShopListByName(string key)
        {
            return _LibraryDal.SearchInBookShopListByName(key);        
        }

        public List<BookShopList> SearchInBookShopListByAuthor(string key)
        {
            return _LibraryDal.SearchInBookShopListByAuthor(key);
        }

        public List<BookShopList> SearchInBookShopListByCategory(string key)
        {
            return _LibraryDal.SearchInBookShopListByCategory(key);
        }
    }
    }


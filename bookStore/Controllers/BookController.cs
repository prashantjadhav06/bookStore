using bookStore.Models;
using bookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        
        public List<BookModel> SearchBook(string bookname, string authorName)
        {
            return _bookRepository.SearchBook(bookname, authorName);
        }
         
        //public string AddBook(string name)
        //{
        //    return "Book added with name = " + name;
        //}
    }
}
 
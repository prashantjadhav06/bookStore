using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }

        public string GetBook(int id)
        {
            return "book with id = "+id;
        }
        
        public string SearchBook(string bookname, string authName)
        {
            return "Boook found with Book name = " + bookname +
                " and Author name = " + authName;
        }
    }
}
 
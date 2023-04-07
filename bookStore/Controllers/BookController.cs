using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
    }
}

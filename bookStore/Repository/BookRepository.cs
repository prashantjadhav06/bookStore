using bookStore.Models;
using System.Linq;

namespace bookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title)
            || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id = 1, Title = "Thermo Dynamics", Author = "Prashant" },
                new BookModel(){ Id = 2, Title = "Fluid Mechanics", Author = "Abhijit" },
                new BookModel(){ Id = 3, Title = "Thoery of Machines", Author = "Venktesh" },
                new BookModel(){ Id = 4, Title = "Turbo Machinary", Author = "Akshay" },
                new BookModel(){ Id = 5, Title = "Design", Author = "Rohit" },
            };
        }
    }
}

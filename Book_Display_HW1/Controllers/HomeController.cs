using Book_Display_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Display_HW1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
        {
            new Book { Name = "Book 1", Author = "Author 1", PageNumber = 200, DueDate = DateTime.Now.AddDays(5) },
            new Book { Name = "Book 2", Author = "Author 2", PageNumber = 150, DueDate = DateTime.Now.AddDays(-2) }
        };

            return View(books);
        }
    }
}

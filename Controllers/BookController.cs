using CetStudent.Models;
using CetStudent.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CetStudent.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                BookService service = new BookService();
              
                var book = service.GetRandomBook();
                return View(book);
            }
            else if (DateTime.Now.DayOfWeek== DayOfWeek.Tuesday)
            {
                return View("DailyBook");
            } else
            {
                return NotFound();
            }
        }

        public IActionResult List()
        {
            return Content("List Page");
        }
    }
}

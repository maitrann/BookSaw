using Microsoft.AspNetCore.Mvc;
using WebApp_BookSaw.CallRESTful;

namespace WebApp_BookSaw.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.allBooks= BookCall.Instance.GetBooks();
            return View();
        }
    }
}

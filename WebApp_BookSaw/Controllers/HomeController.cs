using Microsoft.AspNetCore.Mvc;
using WebApp_BookSaw.CallRESTful;

namespace WebApp_BookSaw.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.lstNewBook = BookCall.Instance.GetNewBooks();
            ViewBag.lstCate = CategoryCall.Instance.GetSomeCategoryAndBooks();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApp_BookSaw.CallRESTful;

namespace WebApp_BookSaw.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            int idClient = 1;
            ViewBag.lsLib = DownBookCall.Instance.GetDownBookViews(idClient);
            return View();
        }
    }
}

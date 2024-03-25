using RestAPI_BookSaw.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp_BookSaw.CallRESTful;

namespace WebApp_BookSaw.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.allBooks = BookCall.Instance.GetBooks();
            return View();
        }
        public IActionResult Information(int id)
        {
            ViewBag.infoBook = BookCall.Instance.GetBooksById(id);
            return View();
        }
        public string DownToLib(int idClient, int idBook)
        {
            DownBook model = new DownBook();
            model.idClient = idClient;
            model.idBook = idBook;
            var down = DownBookCall.Instance.DownBookToLib(model);
            if(down==true)
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
    }
}

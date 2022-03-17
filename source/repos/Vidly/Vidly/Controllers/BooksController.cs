using Microsoft.AspNetCore.Mvc;

namespace Vidly.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}

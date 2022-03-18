using Authorize.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Authorize.Controllers
{
    [CacheResource]
    public class CachedController : Controller
    {
        public IActionResult Index()
        {
            return Content("This content was generated at " + DateTime.Now);
        }
        [ValidateModel]
        [HttpPost]
        public IActionResult Create([FromForm] Book book)
        {
            return View();
        }
        public IActionResult GenerateError()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3.Models;

namespace COMP003B.LectureActivity3.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet("/Store/ViewProduct/{name}/{price}")]
        public IActionResult ViewProduct(string name, decimal price)
        {
            ViewBag.Name = name;
            ViewBag.Price = price;
            return View();
        }

        [HttpGet]
        public IActionResult Search([FromQuery] string category)
        {
            ViewBag.Category = category;
            return View();
        }
    }
}

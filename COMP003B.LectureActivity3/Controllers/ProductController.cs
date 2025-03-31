using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3.Models;

namespace COMP003B.LectureActivity3.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success", product);
            }
            return View(product);
        }

        public IActionResult Success(Product product)
        {
            return View(product);
        }
    }
}

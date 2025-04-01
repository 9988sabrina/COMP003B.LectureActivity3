using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers
{
    public class ShopController : Controller
    {
        //GET: /Shop/
        [HttpGet]
        public IActionResult Index()
        {
            // The view() method returns a view result that rendres a view to the respnse.
            return View();
        }

        // Get:/Shop/Details(in id)
        [HttpGet]

        public IActionResult Details(int id)
        {
            // The view() method returns a view result that renders a view to the response.
            // The id parameter is passed to the view.
            return View(id);
        }
    }
}

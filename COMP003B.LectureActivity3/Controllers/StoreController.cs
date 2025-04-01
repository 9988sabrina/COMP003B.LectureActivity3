using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.LectureActivity3.Controllers
{
    [Route("store")]
    public class StoreController : Controller
    {
        [HttpGet("product/{id:int}")]
        public IActionResult ViewProduct(int id)
        {
            return View(id);
        }

        [HttpGet("product/search")]
        public IActionResult Search([FromQuery] string category)
        {
            return View("Search", category);
        }
    }
}

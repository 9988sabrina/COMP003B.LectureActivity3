using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3.Models;
using System.Reflection.Metadata.Ecma335;

namespace COMP003B.LectureActivity3.Controllers
{
    //The [Route("product")] atrribute specifies that the controller will handle requests that start with "/product".
    public class ProductController : Controller
    {
        //Get: product/create
        //[HttpGet("create")]
        public IActionResult Create()
        {
            //The view=() method returns a view result that renders a view to the response.
            return View();
        }

        //Post: product/create
        [HttpPost("create")]
        public IActionResult Create([FromForm] Product product)

           
        {
            //The Modelstate.IsValid property checks if the model state is valid.
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Success", product);
            }
            return View(product);
        }

           //The RedirectToAction() nitgid retyrb a redirect result that redirects to an action.
            return RedirectToAction("Success", product);
        }
        
        //Get: product/success
        [Route("sucess")]
        public IActionResult Success(Product product)
        {
           //The views() method returns a view result that rendres a view to the response.
            return View(product);
        }
    }
}

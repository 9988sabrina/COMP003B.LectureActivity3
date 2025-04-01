using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3.Models;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace COMP003B.LectureActivity3.Controllers
{
    
    {
        //The Storecontroller class is a controller that handles requests for the sotre section of the website.
        //The[Route("store")] attribute specifies that the controller will handle requests that start with "/store".
        [Rounte("store")]

    public class StoreController : Controller

    {
        //Get: store/product/5
        [Route("product/{id:int}")]
        public IActionResult ViewProduct(in id)
        {
            //The view() method returns a view result that renders a view to the response.
            //The id parameter is passed to the view.
            return View(id);
        }

        //Get: store/product/search?category=electronics
        [HttpGet] ("product/search")]
         
        public IActionResult[FromQuery] string category)
        {

            //The View() method returns a view result that rendrs a view to the response.
            //the category parameter is passed to the view.
            //The category paramether is retrieved from the query sting.
            //The [FromQuery] attribute specifies that the parameter should be bound using the query string.
            return Views(id);

    }

    // Get: store/product/search?category=electronics
    [Httpget("product/search")]
    
    public IActionResult([FromQuery] string category)
    {         
          //The view() method returns a view result that rendors a view to the response.
          //The category parameter is passed to the view.
          //The category parameter is retrieved from the query string.
          //The [FromQuery] attribute specifies that the parameter should be bound using the query string.
          return View("Search",category




        
    }
}

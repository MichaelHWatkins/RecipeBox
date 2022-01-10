using Microsoft.AspNetCore.Mvc;

namespace RecipeBoxControllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Recipes_application.Controllers
{
    public class IngredientController : Controller
    {
      [HttpPost]
       public ActionResult CreateIngredient()
      {
            return View();
      }
        
      [HttpGet]
       public ActionResult NewIngredient()
      {
            return View();
      }

      [HttpGet]
       public ActionResult EditIngredient()
      {
           return View();
      }

      [HttpPut]
       public ActionResult UpdateIngredient()
      {
          return View();
      }

      [HttpGet]
       public ActionResult DestroyIngredient()
      {
          return View();
      }

      [HttpPost]
       public ActionResult DeleteIngredient()
      {
          return View();
      }

    }
}

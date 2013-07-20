using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recipes_application.Controllers
{
    public class RecipeController : Controller
    {
        [HttpGet]
        public ActionResult CreateRecipe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRecipe()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ModifyRecipe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateRecipe()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DestroyRecipe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteRecipe()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RecipesList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RecipeDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchRecipe()
        {
            return View();
        }

          

    }
}

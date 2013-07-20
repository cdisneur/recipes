using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recipes_application.Controllers
{
    public class ShoppingListController : Controller
    {
        [HttpGet]
        public ActionResult ShoppingListDetail()
        {
            return View();
        }

    }
}

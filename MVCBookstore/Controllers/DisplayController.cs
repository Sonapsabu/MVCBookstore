using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookstore.Models;


namespace MVCBookstore.Controllers
{
    public class DisplayController : Controller
    {
        MVCProjectEntities dbobj = new MVCProjectEntities();
        // GET: Display
        public ActionResult display_load(book ob)
        {
            return View();
        }
    }
}
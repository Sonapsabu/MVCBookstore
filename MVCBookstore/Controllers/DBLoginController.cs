using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookstore.Models;
namespace MVCBookstore.Controllers
{
    public class DBLoginController : Controller
    {
        MVCProjectEntities dbobj = new MVCProjectEntities();
        // GET: DBLogin
        public ActionResult Login_pageload()
        {
            return View();
        }

        public ActionResult Home(book ob)
        {
             
            //var list = new List<book>();
            return View(dbobj.books.ToList());
        }

        public ActionResult Login_click(adminlogin objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.Username, objcls.Password, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    Session["uname"] = objcls.Username;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "invalid login";
                    return View("Login_pageload", objcls);
                }
            }
            return View("Login_pageload",objcls);
        }
    }
}
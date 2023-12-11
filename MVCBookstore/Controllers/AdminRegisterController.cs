using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookstore.Models;

namespace MVCBookstore.Controllers
{
    public class AdminRegisterController : Controller
    {
        MVCProjectEntities dbobj = new MVCProjectEntities();
        // GET: AdminRegister
        public ActionResult register_pageload()
        {
            return View();
        }

        public ActionResult register_click(adminregister objcls)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_regadmin(objcls.Name, objcls.Address, objcls.Email, objcls.Username, objcls.Password);
                objcls.msg = "successfully Registered";
                return View("register_pageload", objcls);

            }
            return View("register_pageload",objcls);
        }
    }
}
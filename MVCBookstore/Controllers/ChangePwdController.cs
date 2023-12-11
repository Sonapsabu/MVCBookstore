using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookstore.Models;
namespace MVCBookstore.Controllers
{
    public class ChangePwdController : Controller
    {
        MVCProjectEntities dbobj = new MVCProjectEntities();
        // GET: ChangePwd
        public ActionResult pwd_load()
        {
            return View();
        }
        public ActionResult pwd_click(UserPwd objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status",typeof(int));
                dbobj.sp_pwdchange(Session["uname"].ToString(), objcls.oldpassword, objcls.newpassword, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    objcls.msg = "password changed";
                    return View("pwd_load", objcls);
                }
                else
                {
                    objcls.msg = "invalid password";
                    return View("pwd_load", objcls);
                }

            }
            return View("pwd_load",objcls);
        }
    }
}
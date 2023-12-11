using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookstore.Models;

namespace MVCBookstore.Controllers
{
    public class AddBookController : Controller
    {
        MVCProjectEntities dbobj = new MVCProjectEntities();
        // GET: AddBook
        public ActionResult Book_load()
        {
            return View();
        }

        public ActionResult Book_click(Bookinsert objcls,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/PHS");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);

                    var fullpath = Path.Combine("~\\PHS", fname);
                    objcls.image = fullpath;
                }
                dbobj.sp_bookadd(objcls.bookname, objcls.author, objcls.image, objcls.price);
                objcls.msg = "book added";
                return View("Book_load", objcls);
            }

            return View("Book_load",objcls);
        }
    }
}
using AdamTemplate.DAL;
using AdamTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AdamTemplate.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        PageContext db = new PageContext();

       

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            var userdb = db.Users.FirstOrDefault(m=>m.Name==user.Name && m.Password ==user.Password);
            if(userdb != null)
            {

                FormsAuthentication.SetAuthCookie(user.Name, false);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = "Name or Password Is False";
                return View();
            }
           
        }
    }
}
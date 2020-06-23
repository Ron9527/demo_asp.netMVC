using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNetDemo.Models;

namespace dotNetDemo.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(UserInfo user)
        {
            using (DB_dotNetDemo db = new DB_dotNetDemo())
            {
                var userDetail = db.UserInfo.Where(x => x.Account == user.Account && x.Password == user.Password && x.Authority == user.Authority).FirstOrDefault();
                if (userDetail == null)
                {
                    user.LogInErrorMsg = "Invalid UserName, Password, or Authority";
                    return View("Index", user);
                }
                else
                {
                    Session["Account"] = user.Account;
                    Session["Authority"] = user.Authority;
                    return RedirectToAction("Index", "DeviceInfo");
                }
            }
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index","LogIn");
        }
    }
}
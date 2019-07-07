using BackendFinalProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BackendFinalProject.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly AdminDashboardDBEntities db;

        public LoginController()
        {
            db = new AdminDashboardDBEntities();
        }

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(AdminUser admin)
        {
            bool isMatch = false;

            if (string.IsNullOrEmpty(admin.Email) || string.IsNullOrEmpty(admin.Password))
            {
                Session["loginError"] = "Email or Password Can Not Ne Empty";
                return RedirectToAction("Index", "Login");
            }

            AdminUser adm = db.AdminUsers.FirstOrDefault(a => a.Email == admin.Email);

            if (adm != null)
            {
                isMatch = Crypto.VerifyHashedPassword(adm.Password, admin.Password);

                if (isMatch==true)
                {
                    Session["isLogin"] = true;
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
            }

            Session["loginError"] = "Email or Password is incorrect!";
            return RedirectToAction("Index", "Login");
        }

        public ActionResult SignOut()
        {
            Session["isLogin"] = null;
            return RedirectToAction("Index", "Login");
        }

        public ActionResult HassPass()
        {
            string p = "test123";
            string hashedPass = Crypto.HashPassword(p);


            return Content(hashedPass);
        }
    }
}
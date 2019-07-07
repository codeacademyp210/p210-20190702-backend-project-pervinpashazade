using BackendFinalProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendFinalProject.Areas.Admin.Controllers
{
    [Auth]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult UsersList()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }
    }
}
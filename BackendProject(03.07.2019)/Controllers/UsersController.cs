using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendProject_03._07._2019_.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UsersList()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }
    }
}
using BackendFinalProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendFinalProject.Areas.Admin.Controllers
{
    [Auth]
    public class PackagesController : Controller
    {
        // GET: Admin/Packages
        public ActionResult Index()
        {
            return View();
        }
    }
}
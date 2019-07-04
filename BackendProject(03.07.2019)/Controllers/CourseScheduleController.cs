using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendProject_03._07._2019_.Controllers
{
    public class CourseScheduleController : Controller
    {
        // GET: CourseSchedule
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Rooms()
        {
            return View();
        }

        public ActionResult Trainers()
        {
            return View();
        }
    }
}
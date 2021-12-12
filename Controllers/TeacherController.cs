using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcSchool.Controllers
{
    public class TeacherController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTeacherName()
        {
            ViewBag.teacherName = "Jacob";
            return View();
        }

        public ActionResult GetTeacher()
        {
            return View();
        }

        public ActionResult GetAllTeachersNames()
        {
            ViewBag.teachersArray = new string[] { "teacher1", "teacher2", "teacher3", "teacher4", "teacher5", "teacher6" };
            return View();
        }

        public ActionResult GetAllTeachers()
        {
            return View();
        }

    }
}
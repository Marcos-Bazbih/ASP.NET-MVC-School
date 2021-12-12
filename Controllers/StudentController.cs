using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcSchool.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudentName()
        {
            ViewBag.Name = "Marcos Bazbih";
            return View();
        }

        public ActionResult GetStudent()
        {
            return View();
        }

        public ActionResult GetAllStudentsNames()
        {
            ViewBag.namesArray = new string[] { "Messi", "Ronaldinho", "Eto'o", "Xavi", "Iniesta", "Busi" };
            return View();
        }

        public ActionResult GetAllStudents()
        {
            return View();
        }

        public ActionResult GetJson()
        {
            string[] namesArray = new string[] { "Messi", "Ronaldinho", "Etoo", "Xavi", "Iniesta", "Busi" };
            return Json(namesArray, JsonRequestBehavior.AllowGet);
        }

    }
}
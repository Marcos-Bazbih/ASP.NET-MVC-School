using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcSchool.Controllers
{
    public class ManagerController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetManagerName()
        {
            ViewBag.Name = "Marcos Bazbih";
            return View();
        }

        public ActionResult GetManager()
        {
            return View();
        }

        public ActionResult GetAllManagersNames()
        {
            ViewBag.managersArray = new string[] { "manager1", "manager2", "manager3", "manager4", "manager5", "manager6" };
            return View();
        }

        public ActionResult GetAllManagers()
        {
            return View();
        }

        public ActionResult GetEvenNumbers()
        {
            ViewBag.randomNumsArray = new int[10];
            Random randomNum = new Random();

            for (int i = 0; i < ViewBag.randomNumsArray.Length; i++)
            {
                ViewBag.randomNumsArray[i] = randomNum.Next(0, 10);
            }

            return View();
        }

        public ActionResult GetNamesLongerThen4()
        {
            ViewBag.lastNames = new string[]
            { "asd", "asdasdasd", "aa", "asdasd", "asdd",
                "a", "asddd", "asdasdsd", "aa", "asddddd" };

            return View();
        }


    }
}
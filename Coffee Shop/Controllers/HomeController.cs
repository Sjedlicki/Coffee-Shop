using Coffee_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Coffee Shop only provides the best coffees from around the world!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Info";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Summary(User u)
        {
            ViewBag.First = u.Firstname;
            ViewBag.Last = u.Lastname;
            ViewBag.Email = u.Email;
            ViewBag.Pass = u.Password;
            ViewBag.Phone = u.Phone;
            return View();
        }
    }
}
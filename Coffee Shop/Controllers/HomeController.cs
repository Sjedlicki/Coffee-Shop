using Coffee_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public ActionResult PasswordMismatch()
        {
            ViewBag.message = "Oops, Something went wrong, check yourself before you wreck yourself";
            return View();
        }

        public ActionResult Summary(User u)
        {
            var num = new HashSet<int> { 1,2,3,4,5,6,7,8,9,0};
            string nums = "0123456789";

            if (u.Password == null || u.Password != u.ConfirmPassword)
            {
                ViewBag.message = "Password does not match. Re-enter Password";
                return RedirectToAction("PasswordMismatch");
            }
            else if (u.Email == null)
            {
                ViewBag.message = "Invalid email address. Please enter a valid email";
                return RedirectToAction("Registration");
            }
            else if (u.Firstname == null)
            {
                ViewBag.message = "First name field cannot be left empty";
                return RedirectToAction("PasswordMismatch");
            }
            else if (u.Lastname == null)
            {
                ViewBag.message = "Last name field cannot be left empty";
                return RedirectToAction("PasswordMismatch");
            }
            else
            {
                ViewBag.First = u.Firstname;
                ViewBag.Last = u.Lastname;
                ViewBag.Email = u.Email;
                ViewBag.Pass = u.Password;
                ViewBag.ConfirmPassword = u.ConfirmPassword;
                ViewBag.Phone = u.Phone;
                return View();
            }
        }
    }
}
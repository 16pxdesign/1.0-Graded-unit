using Graded_unit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Graded_unit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User admin = new User();
            admin.username = "admin";
            admin.password = "password";
            DatabaseModel db = new DatabaseModel();
           // db.User.Add(admin);
           // db.SaveChanges();

            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
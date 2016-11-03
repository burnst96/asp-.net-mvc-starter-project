using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TestsController : Controller
    {
        public ActionResult Test()
        {
            User u = new UserBAL().getUser();
            System.Console.WriteLine(u.password + u.username);
            ViewBag.UserData = u;
            return View();
        }

    }
}
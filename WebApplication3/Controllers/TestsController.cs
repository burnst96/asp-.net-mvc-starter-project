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

        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Form(User u)
        {
            if(ModelState.IsValid)
            {
                String upper = u.username.First().ToString().ToUpper();
                String lower = u.username.Substring(1);
                u.username = upper + lower;

                return View("Result", u);
            } else
            {
                return View();
            }
        }

    }
}
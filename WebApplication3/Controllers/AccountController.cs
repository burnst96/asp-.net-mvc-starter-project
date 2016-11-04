using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Persistence;

namespace WebApplication3.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateInput(true)]
        public ActionResult Login(User u)
        {
            if (ModelState.IsValid)
            {
                String upper = u.username.First().ToString().ToUpper();
                String lower = u.username.Substring(1);
                u.username = upper + lower;

                return View("Result", u);
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateInput(true)]
        public ActionResult Register(User u)
        {
            if(new OracleDAO().checkConnection())
            {
                //Add Database INSERT Statement
            } else
            {
                //If Database Is Down or Not Running, Store All Details In Memory
                MockDAO.Insert(u);
            }
            return View("Welcome", u);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class UserBAL
    {
        public User getUser()
        {
            User u = new Models.User("mockuser","mockpass");
            return u;
        }
    }
}
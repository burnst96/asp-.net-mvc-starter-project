using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using WebApplication3.Persistence;

namespace WebApplication3.Models
{
    public class User
    {
        public int id { get; set; }

        [MaxLength(16, ErrorMessage = "Username Must be Less than 16 Characters Long!")]
        [Required(ErrorMessage = "Username Required!")]
        [Display(Name = "Username: ")]
        public String username { get; set; }

        [MinLength(8, ErrorMessage = "Password Must be 8 Characters Long!")]
        [Required(ErrorMessage = "Password Required!")]
        [Display(Name = "Password: ")]
        public String password { get; set; }

        public User(String username, String password)
        {

            this.username = username;
            this.password = password;
            this.id = MockDAO.generateNewUserID();
        }

        public User()
        {
            id = MockDAO.generateNewUserID();
        }
    }
}
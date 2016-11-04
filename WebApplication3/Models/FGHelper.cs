using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class FGHelper
    {
        public static String[] buttons;

        [Required(ErrorMessage = "Form Title Required!")]
        [MaxLength(80, ErrorMessage = "Title Must Contain Less Than 80 Characters!")]
        [Display(Name = "Title: ")]
        public String title { get; set; }

        [MaxLength(120, ErrorMessage = "Description Cannot Contain More Than 120 Characters!")]
        [Display(Name = "Description: ")]
        public String desc { get; set; }

        public static void init()
        {
            buttons = new String[10];
            buttons.SetValue("TextBox",0);
            buttons.SetValue("ComboBox", 1);
            buttons.SetValue("CheckBoxList", 2);
            buttons.SetValue("RadioButtonList", 3);
        }
    }
}
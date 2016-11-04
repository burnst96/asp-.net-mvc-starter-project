using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class FormGenController : Controller
    {

        public ActionResult FormGen()
        {
            FGHelper.init();
            return View();
        }

        [HttpPost, ValidateInput(true)]
        public ActionResult FormGen(FGHelper fg)
        {
            
            return View("DynamicFormPage", fg);
        }

    }
}
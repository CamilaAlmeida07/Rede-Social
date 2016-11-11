using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redeSocial.Controllers
{
    public class homeController : Controller
    {
        public ActionResult home()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult duelos()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult ranking()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult conquistas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult perfil()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult paginas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

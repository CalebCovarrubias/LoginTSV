using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginTSV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vamos a ver que pasa si hago esta modificacion";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tu contacto de la pagina";

            return View();
        }
    }
}
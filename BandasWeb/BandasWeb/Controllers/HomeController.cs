using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandasWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData["bw_usuario"] = bw_usuario;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de nosotros";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Musicos()
        {
            ViewBag.Message = "Your Music page.";

            return View();
        }
    }
}
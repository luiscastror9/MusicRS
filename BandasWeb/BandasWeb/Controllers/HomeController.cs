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
            Database1Entities d = new Database1Entities();
            d.Detalle_sala.FirstOrDefault().Sala.
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

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
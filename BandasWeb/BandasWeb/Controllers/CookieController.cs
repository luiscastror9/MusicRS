using BandasWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandasWeb.Controllers
{
    public class CookieController : Controller
    {
        public ControllerContext contexto = new System.Web.Mvc.ControllerContext();

        // GET: Cookie
        public ActionResult Create(ApplicationUser user)
        {

            HttpCookie bw_usuario = new HttpCookie("bw_usuario", user.UserName)
            {
                HttpOnly = true,
                Domain = "/",
                Secure = false,
                Expires = DateTime.Now.AddDays(1)
            };

            /*/ControllerContext/*/ contexto.HttpContext.Response.Cookies.Add(bw_usuario);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Remove()
        {
            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("bw_usuario"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["bw_usuario"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Index", "Home");
        }


    }
}

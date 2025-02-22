using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteQuanLyDinhDuongCaNhan.Controllers
{
    public class AuthController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            ViewData["HideHeader"] = true;
            return View();
        }
    }
}
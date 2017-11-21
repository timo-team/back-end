using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeemoBack.Controllers
{
    public class TeemoController : Controller
    {
        // GET: Teemo
        public ActionResult Index()
        {
            return View();
        }
    }
}
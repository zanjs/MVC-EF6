using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anla.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            ViewBag.Number = 99;
            ViewBag.Name = "anla";
            ViewBag.list = new List<string> { "S1", "S2", "S3" };
            return View();
        }

        //public String Index(string id)
        //{
        //    return "page id is "+ id;
        //}

        public String Another()
        {
            return " null";
        }
    }
}
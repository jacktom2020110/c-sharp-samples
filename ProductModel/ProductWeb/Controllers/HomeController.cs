using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProductBIL;
using ProductModels;

namespace ProductWeb.Controllers
{
    public class HomeController : Controller
    {
        ProBill bll = new ProBill();

        public ActionResult Index()
        {
            
            return View(bll.GetProducts());
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
    }
}
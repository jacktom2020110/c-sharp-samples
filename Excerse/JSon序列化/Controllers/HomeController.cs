using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JSon序列化.Models;

using System.Web.Script.Serialization;

namespace JSon序列化.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JsonDemo()
        {
            Person p = new Person
            {
                UserID = 1001,
                UserName = "Jack",
                Address = "China"
            };

            JavaScriptSerializer jss = new JavaScriptSerializer();

            var js = jss.Serialize(p);

            ViewBag.js = js;

            return View();
           
        }
    }
}
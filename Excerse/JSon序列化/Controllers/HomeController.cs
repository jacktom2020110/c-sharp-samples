using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JSon序列化.Models;

// 引用Json序列化的命名空间
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


        /// <summary>
        /// 将类序列化为Json数据
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 将Json数据反序列化为自定义类对象
        /// </summary>
        /// <returns></returns>
        public ActionResult DeJson()
        {
            var json = "{ \"UserID\":\"1002\",\"UserName\":\"Tom\",\"Address\":\"US\" }";

            JavaScriptSerializer jse = new JavaScriptSerializer();
    
            Person p = jse.Deserialize<Person>(json);

            ViewBag.user = p;

            return View();
        }

    }
}
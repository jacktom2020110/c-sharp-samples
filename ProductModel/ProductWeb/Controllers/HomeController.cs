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
            ViewBag.cid = new SelectList(bll.GetCategories(),"CategoryID","CategoryName");

            return View(bll.GetProducts());
        }

        public ActionResult Search(string pName, int? cid)
        {
            List<Product> lst = bll.Search(pName, cid);
            ViewBag.cid = new SelectList(bll.GetCategories(), "CategoryID", "CategoryName");

            return View("Index",lst);
        }

        public ActionResult Edit(int id)
        {
            Product pro = bll.GetProductByPID(id);

            ViewBag.CategoryID = new SelectList(bll.GetCategories(), "CategoryID", "CategoryName",pro.CategoryID);

            return View(pro);

        }

        public ActionResult Editdo(Product pro)
        {
            if (bll.Edit(pro) > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>Alert('修改失败!')</script>");
            }
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
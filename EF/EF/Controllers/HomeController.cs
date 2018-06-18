using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EF.Models;

#region 身份认证库
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
#endregion

namespace EF.Controllers
{
    public class HomeController : Controller
    {
        ProductEntity entity = new ProductEntity();

        public ActionResult Index()
        {
            //ProductEntity entity = new ProductEntity();

            List<Product> lst = entity.Products.ToList(); //当使用数据库上下文去操作数据库的时候会生成数据库和表

            return View(lst);
        }

        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 添加一个产品
        /// </summary>
        /// <param name="pro">产品</param>
        /// <returns></returns>
        public ActionResult AddDo(Product pro)
        {
            //添加
            entity.Products.Add(pro);

            //保存至数据库
            entity.SaveChanges();

            //返回产品首页
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Del(int id)
        {
            //通过ID查找要删除的产品
            Product pro = entity.Products.Find(id);

            //删除产品
            entity.Products.Remove(pro);

            //保存至数据库
            if (entity.SaveChanges() > 0)
            {
                //返回产品首页
                return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('删除失败')</script>");
            }

            
        }


        public ActionResult Edit(int id)
        {
            Product pro = entity.Products.Find(id);

            return View(pro);

        }
        public ActionResult EditPro(Product pro)
        {
            entity.Entry(pro).State = EntityState.Modified;

            if (entity.SaveChanges() > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('修改失败')</script>");
            }

        }



        /// <summary>
        /// Send an OpenID Connect sign-in request.
        /// Alternatively, you can just decorate the SignIn method with the [Authorize] attribute
        /// </summary>
        public void SignIn()
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
        }

        /// <summary>
        /// Send an OpenID Connect sign-out request.
        /// </summary>
        public void SignOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(
                OpenIdConnectAuthenticationDefaults.AuthenticationType,
                CookieAuthenticationDefaults.AuthenticationType);
        }
    }
}
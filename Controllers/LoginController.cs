using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcOnlineAutomationProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult CurrentPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult CurrentPartial(Current current)
        {
            context.Currents.Add(current);
            context.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public ActionResult CurrentLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CurrentLogin(Current current)
        {
            var Value=context.Currents.FirstOrDefault(x=>x.CurrentEmail==current.CurrentEmail && x.CurrentPassword==current.CurrentPassword);
            if (Value!=null)
            {
                FormsAuthentication.SetAuthCookie(Value.CurrentEmail, false);
                Session["CurrentEMail"] = Value.CurrentEmail.ToString();
                return RedirectToAction("Index", "CurrentPanel");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        [HttpGet]
        public  ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            var Value=context.Admins.FirstOrDefault(x=>x.UseName==admin.UseName && x.Password==admin.Password);
            if (Value!=null)
            {
                FormsAuthentication.SetAuthCookie(Value.UseName, false);
                Session["UserName"] = Value.UseName.ToString();
                return RedirectToAction("Index", "Category");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


    }
}
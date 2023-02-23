using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
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
    }
}
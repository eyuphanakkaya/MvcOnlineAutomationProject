using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class GaleryController : Controller
    {
        // GET: Galery
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.Products.ToList();
            return View(Values);
        }
    }
}
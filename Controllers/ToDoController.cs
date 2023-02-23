using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        Context context = new Context();
        public ActionResult Index()
        {
            var Value1 = context.Currents.Count().ToString();
            ViewBag.V=Value1;
            var Value2 = context.Products.Count().ToString();
            ViewBag.V2=Value2;
            var Value3=context.Categories.Count().ToString();
            ViewBag.V3=Value3;
            var Value4= (from x in context.Currents select x.CurrentCity).Distinct().Count().ToString();
            ViewBag.V4 = Value4;
            var Value = context.ToDos.ToList();
            return View(Value);
        }
    }
}
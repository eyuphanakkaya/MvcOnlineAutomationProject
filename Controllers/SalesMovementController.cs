using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class SalesMovementController : Controller
    {
        // GET: SalesMovement
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.SalesMovements.ToList();
            return View(Values);
        }
        [HttpGet]
        public ActionResult AddSalesMovement()
        {
            List<SelectListItem> Values = (from i in context.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.ProductName,
                                               Value = i.ProductId.ToString()
                                           }
                                      ).ToList();
            ViewBag.V = Values;
            return View();
        }
        [HttpPost]
        public ActionResult AddSalesMovement(SalesMovement salesMovement)
        {
            var Value=context.SalesMovements.Add(salesMovement);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
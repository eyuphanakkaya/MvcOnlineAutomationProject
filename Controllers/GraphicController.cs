using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class GraphicController : Controller
    {
        // GET: Graphic
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeProductResult()
        {
            return Json(ProductList(), JsonRequestBehavior.AllowGet);
        }
        public List<Graphics> ProductList()
        {
            List<Graphics> graphics=new List<Graphics>();
            using (var context = new Context())
            {
                graphics = context.Products.Select(x => new Graphics
                {
                    Product = x.ProductName,
                    Stock = x.Stock
                }).ToList();
            }
            return graphics;
        }
    }
}
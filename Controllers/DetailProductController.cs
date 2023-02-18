using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class DetailProductController : Controller
    {
        // GET: DetailProduct
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.Products.Where(x => x.ProductId == 1).ToList();
            return View(Values);
        }
    }
}
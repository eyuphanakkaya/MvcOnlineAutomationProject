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
            DetailStatementProduct detailStartmant = new DetailStatementProduct();
            //var Values = context.Products.Where(x => x.ProductId == 1).ToList();
            detailStartmant.Products1 = context.Products.Where(x => x.ProductId == 1).ToList();
            detailStartmant.Details1=context.Details.Where(y=>y.DetailId==1).ToList();
            return View(detailStartmant);
        }
    }
}
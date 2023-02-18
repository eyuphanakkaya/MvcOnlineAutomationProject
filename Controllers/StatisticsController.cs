using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        Context context = new Context();
        public ActionResult Index()
        {
            var Value1 = context.Currents.Count().ToString();
            ViewBag.V1 = Value1;
            var Value2 = context.Products.Count().ToString();
            ViewBag.V2 = Value2;
            var Value3 = context.Employees.Count().ToString();
            ViewBag.V3 = Value3;
            var Value4=context.Categories.Count().ToString();
            ViewBag.V4 = Value4;
            var Value5 = context.Products.Sum(x=>x.Stock).ToString();
            ViewBag.V5 = Value5;
            var Value6 = (from x in context.Products select x.Brand).Distinct().Count().ToString();//distinct tekrar etmeyi engeller
            ViewBag.V6 = Value6;
            var Value7 = context.Products.Count(x=>x.Stock<=12).ToString();
            ViewBag.V7 = Value7;
            var Value8 = (from x in context.Products orderby x.SellPrice descending select x.ProductName).FirstOrDefault();//firstordefault ilk değeri getir demek
            ViewBag.V8 = Value8;
            var Value9 = (from x in context.Products orderby x.SellPrice ascending select x.ProductName).FirstOrDefault();
            ViewBag.V9 = Value9;
            var Value10 = context.Products.GroupBy(x => x.Brand).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            ViewBag.V10 = Value10;
            var Value11 = context.Products.Count(x => x.ProductName == "Televizyon").ToString();
            ViewBag.V11 = Value11;
            var Value12 = context.Products.Count(x=>x.ProductName=="Bilgisayar").ToString();
            ViewBag.V12 = Value12;
            var Value13 = context.Products.Where(c => c.ProductId == (context.Products.GroupBy(x => x.ProductId).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault())).Select(k => k.ProductName).FirstOrDefault();
            ViewBag.V13 = Value13;
            var Value14 = context.SalesMovements.Sum(x=>x.TotalPrice).ToString();
            ViewBag.V14 = Value14;
            DateTime Vlu=DateTime.Now;
            var Value15 = context.SalesMovements.Count(x => x.Date == Vlu).ToString();
            ViewBag.V15 = Value15;
            //var Value16 = context.SalesMovements.Where(x=>x.Date==Vlu).Sum(y=>y.TotalPrice).ToString();
            //ViewBag.V16 = Value16;

            return View();
        }
    }
}
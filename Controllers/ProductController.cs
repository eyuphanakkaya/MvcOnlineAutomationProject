using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context context = new Context();
        public ActionResult Index(string p)
        {
            var Values = from x in context.Products select x;
            if (!string.IsNullOrEmpty(p))
            {
                Values = Values.Where(y => y.ProductName.Contains(p));
            }
            return View(Values.ToList());
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> Value = (from x in context.Categories.ToList()
                                          select new SelectListItem 
                                          { 
                                          Text=x.CategoryName,//bize gözükecek alan
                                          Value=x.CategoryId.ToString()
                                          }).ToList();
            ViewBag.Values = Value;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetProduct(int Id)
        {
            List<SelectListItem> Value = (from x in context.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,//bize gözükecek alan
                                              Value = x.CategoryId.ToString()
                                          }).ToList();
            ViewBag.Vle = Value;
            var Values = context.Products.Find(Id);
            return View("GetProduct", Values);
        }
        public ActionResult DeleteProduct(int Id)
        {
            var Values = context.Products.Find(Id);
            Values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateProduct(Product product)
        {
            var Values = context.Products.Find(product.ProductId);
            Values.ProductName = product.ProductName;
            Values.Brand = product.Brand;
            Values.Status = product.Status;
            Values.BuyPrice = product.BuyPrice;
            Values.SellPrice = product.SellPrice;
            Values.Category = product.Category;
            Values.ProductImage = product.ProductImage;
            Values.Status = product.Status;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ProductList()
        {
            var Value=context.Products.ToList();
            return View(Value);
        }

    }
}
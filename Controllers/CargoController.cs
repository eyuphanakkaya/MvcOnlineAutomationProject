using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class CargoController : Controller
    {
        // GET: Cargo
        Context context = new Context();
        public ActionResult Index(string p)
        {
            var Values = from x in context.CargoDetails select x;
            if (!string.IsNullOrEmpty(p))
            {
                Values = Values.Where(y => y.StarckingCode.Contains(p));
            }
            //var Value = context.CargoDetails.ToList();
            return View(Values.ToList());
        }
        [HttpGet]
        public ActionResult AddCargo()
        {
            Random random = new Random();
            string[] character={"A","B","C","D" };
            int k1, k2, k3;
            k1 = random.Next(0, 4);
            k2 = random.Next(0, 4);
            k3= random.Next(0, 4);
            int s1,s2, s3;
            s1 = random.Next(100,1000);
            s2 = random.Next(10,99);
            s3 = random.Next(10, 99);
            string Code=s1.ToString() + character[k1] + s2 + character[k2] + s3 + character[k3];
            ViewBag.code = Code;
            return View();
        }
        [HttpPost]
        public ActionResult AddCargo(CargoDetail cargoDetail)
        {
            context.CargoDetails.Add(cargoDetail);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CargoTracking(string id)
        {
            var Value = context.CargoTrackings.Where(x => x.StarckingCode == id).ToList();
            return View(Value);
        }
    }
}
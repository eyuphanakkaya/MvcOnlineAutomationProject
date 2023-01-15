using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class DepartmantController : Controller
    {
        // GET: Departmant
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.Departmants.ToList();
            return View(Values);
        }
        [HttpGet]
        public ActionResult AddDepartmant()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartmant(Departmant departmant)
        {
            context.Departmants.Add(departmant);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
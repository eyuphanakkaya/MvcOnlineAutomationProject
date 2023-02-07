using Antlr.Runtime;
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
            var Values = context.Departmants.Where(x=>x.Status==true).ToList();
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
        public ActionResult DeleteDepartmant(int id)
        {
            var Values = context.Departmants.Find(id);
            Values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetDepartmant(int id)/*değer taşımak için*/
        {
            var Values = context.Departmants.Find(id);
            return View("GetDepartmant",Values);
        }
        public ActionResult UpdateDepartmant(Departmant departmant)
        {
            var Values = context.Departmants.Find(departmant.DepartmantId);
            Values.DepartmantName = departmant.DepartmantName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailDepartmant(int id)
        {
            var Values=context.Employees.Where(x=>x.Departmantid==id).ToList();
            var Vlu = context.Departmants.Where(x => x.DepartmantId == id).Select(y => y.DepartmantName).FirstOrDefault();
            ViewBag.V = Vlu;
            return View(Values);
        }
        public ActionResult SalesDepartmant(int id)
        {
            var Values = context.SalesMovements.Where(x => x.Employeeid == id).ToList();
            var Vlu=context.Employees.Where(x=>x.EmployeeId == id).Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.V=Vlu;

            return View(Values);
        }
    }
}
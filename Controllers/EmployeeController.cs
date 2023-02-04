using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.Employees.ToList();
            return View(Values);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult AddEmloyee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
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
            List<SelectListItem> Values = (from i in context.Departmants.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.DepartmantName,
                                               Value = i.DepartmantId.ToString()
                                           }
                                         ).ToList();
            ViewBag.V = Values;
            return View();
        }
        [HttpPost]
        public ActionResult AddEmloyee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetEmployee(int id)
        {
            List<SelectListItem> Value = (from i in context.Departmants.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.DepartmantName,
                                              Value = i.DepartmantId.ToString()
                                          }
                                         ).ToList();
            ViewBag.V = Value;
            var Values = context.Employees.Find(id);
            return View("GetEmployee", Values);
        }
        public ActionResult UpdateEmployee(Employee employee)
        {
            var Values=context.Employees.Find(employee.EmployeeId);
            Values.EmployeeName= employee.EmployeeName;
            Values.EmployeeSurname= employee.EmployeeSurname;
            Values.EmployeeImage= employee.EmployeeImage;
            Values.Departmantid=employee.Departmantid;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EmployeeList()
        {
            var Values = context.Employees.ToList();
            return View(Values);
        }
    }
}
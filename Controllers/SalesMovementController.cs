using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class SalesMovementController : Controller
    {
        // GET: SalesMovement
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.SalesMovements.ToList();
            return View(Values);
        }
        [HttpGet]
        public ActionResult AddSalesMovement()
        {
            List<SelectListItem> Values = (from i in context.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.ProductName,
                                               Value = i.ProductId.ToString()
                                           }
                                      ).ToList();
            List<SelectListItem> Values2 = (from i in context.Currents.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.CurrentName + " " + i.CurrentSurname,
                                                Value = i.CurrentId.ToString()
                                            }
                                            ).ToList();
            List<SelectListItem> Values3 = (from i in context.Employees.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.EmployeeName + " " + i.EmployeeSurname,
                                                Value = i.EmployeeId.ToString()

                                            }
                                          ).ToList();
            ViewBag.V = Values;
            ViewBag.V1 = Values2;
            ViewBag.V2 = Values3;
            return View();
        }
        [HttpPost]
        public ActionResult AddSalesMovement(SalesMovement salesMovement)
        {
            salesMovement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var Value=context.SalesMovements.Add(salesMovement);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetSalesMovement(int id)
        {
            List<SelectListItem> Values = (from i in context.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.ProductName,
                                               Value = i.ProductId.ToString()
                                           }
                          ).ToList();
            List<SelectListItem> Values2 = (from i in context.Currents.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.CurrentName + " " + i.CurrentSurname,
                                                Value = i.CurrentId.ToString()
                                            }
                                            ).ToList();
            List<SelectListItem> Values3 = (from i in context.Employees.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.EmployeeName + " " + i.EmployeeSurname,
                                                Value = i.EmployeeId.ToString()

                                            }
                                          ).ToList();
            ViewBag.V = Values;
            ViewBag.V1 = Values2;
            ViewBag.V2 = Values3;
            var Values1 = context.SalesMovements.Find(id);
            return View("GetSalesMovement", Values1);
        }
        public ActionResult UpdateSalesMovement(SalesMovement salesMovement)
        {
            var Values = context.SalesMovements.Find(salesMovement.SalesMovementsId);
            Values.Piece = salesMovement.Piece;
            Values.Price = salesMovement.Price;
            Values.TotalPrice = salesMovement.TotalPrice;
            Values.Employeeid = salesMovement.Employeeid;
            Values.Currentid = salesMovement.Currentid;
            Values.Productid = salesMovement.Productid;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailSalesMovements(int id)
        {
            var Values = context.SalesMovements.Where(x => x.SalesMovementsId == id).ToList();
            return View(Values);
        }
    }
}
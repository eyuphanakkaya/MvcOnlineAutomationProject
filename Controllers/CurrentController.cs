using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class CurrentController : Controller
    {
        // GET: Current
        Context context = new Context();
        public ActionResult Index()
        {
            var Values = context.Currents.Where(x=>x.Status==true).ToList();
            return View(Values);
        }
        public ActionResult StatusCurrent(int  id)
        {
            var Values = context.Currents.Find(id);
            Values.Status = false;
            context.SaveChanges();  
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddCurrent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCurrent(Current current)
        {
            context.Currents.Add(current);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCurrent(int id)
        {
            var Values=context.Currents.Find(id);   
            return View("GetCurrent", Values);
        }
        public ActionResult UpdateCurrent(Current current)
        {
            var Values=context.Currents.Find(current.CurrentId);
            Values.CurrentName = current.CurrentName;
            Values.CurrentSurname=current.CurrentSurname; 
            Values.CurrentEmail = current.CurrentEmail;
            Values.CurrentCity=current.CurrentCity;
            Values.Status = current.Status;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailCurrent(int id)
        {
            var Values = context.SalesMovements.Where(x => x.Currentid ==id).ToList();
            var Vlu=context.Currents.Where(x=>x.CurrentId==id).Select(y=>y.CurrentName + " " + y.CurrentSurname).FirstOrDefault();
             ViewBag.V = Vlu;
            return View(Values);
        }
    }
}
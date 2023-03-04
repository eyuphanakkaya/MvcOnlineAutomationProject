using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcOnlineAutomationProject.Controllers
{
    public class CurrentPanelController : Controller
    {
        Context context = new Context();
        // GET: CurrentPanel
        [Authorize]
        public ActionResult Index()
        {
            var CurrentMail = (string)Session["CurrentEmail"];
            var Value = context.Currents.FirstOrDefault(x => x.CurrentEmail == CurrentMail);
            return View(Value);
        }
        [Authorize]
        public ActionResult Order()
        {
            var CurrentMail = (string)Session["CurrentEmail"];
            var Id=context.Currents.Where(x=>x.CurrentEmail==CurrentMail).Select(y=>y.CurrentId).FirstOrDefault();
            var Value = context.SalesMovements.Where(x => x.Currentid == Id).ToList();
            return View(Value);
        }
        [Authorize]
        public ActionResult MessageDetail(int id)
        {

            var Values = context.Messages.Where(x => x.MessageId == id).ToList();
            var Email = (string)Session["CurrentEmail"];
            var NumberOutgoing = context.Messages.Count(x => x.Sender == Email).ToString();
            ViewBag.V1 = NumberOutgoing;
            var NumberArrivals = context.Messages.Count(x => x.Receiver == Email).ToString();
            ViewBag.V = NumberArrivals;
            return View(Values);
        }
        [Authorize]
        [HttpGet]
        public ActionResult NewMessage()
        {
            var Email = (string)Session["CurrentEmail"];
            var NumberOutgoing = context.Messages.Count(x => x.Sender == Email).ToString();
            ViewBag.V1 = NumberOutgoing;
            var NumberArrivals = context.Messages.Count(x => x.Receiver == Email).ToString();
            ViewBag.V = NumberArrivals;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            var Email = (string)Session["CurrentEmail"];
            message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            message.Sender=Email;
            context.Messages.Add(message);
            context.SaveChanges();
            return View();
        }
        [Authorize]
        public ActionResult CargoTracking(string p)
        {
            var Values = from x in context.CargoDetails select x;
            Values = Values.Where(y => y.StarckingCode.Contains(p));
            //var Value = context.CargoDetails.ToList();
            return View(Values.ToList());
        }
        [Authorize]
        public ActionResult CargoDetail(string id)
        {
            var Value = context.CargoTrackings.Where(x => x.StarckingCode == id).ToList();
            return View(Value);
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}
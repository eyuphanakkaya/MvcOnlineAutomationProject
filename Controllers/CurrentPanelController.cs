using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

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
        public ActionResult Order()
        {
            var CurrentMail = (string)Session["CurrentEmail"];
            var Id=context.Currents.Where(x=>x.CurrentEmail==CurrentMail).Select(y=>y.CurrentId).FirstOrDefault();
            var Value = context.SalesMovements.Where(x => x.Currentid == Id).ToList();
            return View(Value);
        }
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
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message  message)
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class CurrentPanelController : Controller
    {
        // GET: CurrentPanel
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}
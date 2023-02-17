using MvcOnlineAutomationProject.Models.EntityFramework;
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineAutomationProject.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        Context context = new Context();
        public ActionResult Index()
        {
            var Value = context.Bills.ToList();
            return View(Value);
        }
        [HttpGet]
        public ActionResult AddBill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBill(Bill bill)
        {
            var Value = context.Bills.Add(bill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBill(int id)
        {
            var Values = context.Bills.Find(id);
            return View("GetBill", Values);
        }
        public ActionResult UpdateBill(Bill bill)
        {
            var Values = context.Bills.Find(bill.BillId);
            Values.Date = bill.Date;
            Values.Time=bill.Time;
            Values.BillRowNumber= bill.BillRowNumber;
            Values.BillSerialNumber = bill.BillSerialNumber;
            Values.Delivery = bill.Delivery;
            Values.Receiver = bill.Receiver;
            Values.TaxAdministration = bill.TaxAdministration;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailBill(int id)
        {
            var Values = context.InvoiceItems.Where(x => x.Billid == id).ToList();
            var Vlu = context.Bills.Where(x => x.BillId == id).Select(y => y.BillSerialNumber).FirstOrDefault();
            ViewBag.V = Vlu;
            return View(Values);
        }

        public ActionResult AddInvoiceItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoiceItem(InvoiceItem invoiceItem)
        {
            var Values=context.InvoiceItems.Add(invoiceItem);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
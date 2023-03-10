using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomationProject.Models.EntityFramework
{
    public class Bill:Entity
    {
        [Key]
        public int BillId { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string BillSerialNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string BillRowNumber { get; set; }


        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxAdministration { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string Time { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Delivery { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }

        public decimal Total { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }



    }
}

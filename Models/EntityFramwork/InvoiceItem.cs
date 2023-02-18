using MvcOnlineAutomationProject.Models.EntityFramwork;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomationProject.Models.EntityFramework
{
    public class InvoiceItem:Entity
    {
        [Key]
        public int InvoiceItemId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Statement { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public int Billid { get; set; }
        public virtual Bill Bill { get; set; }

    }
}

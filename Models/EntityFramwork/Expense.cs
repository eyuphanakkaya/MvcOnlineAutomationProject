using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class Expense
    {
        [Key]
        public int ExpelnseId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Statement { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}

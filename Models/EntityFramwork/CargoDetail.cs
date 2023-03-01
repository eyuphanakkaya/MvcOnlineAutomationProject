using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class CargoDetail
    {
        [Key]
        public int CargoDetailId { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(100)]
        public string Explanation { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string StarckingCode { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Employee { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Receiver { get; set; }
        public DateTime Date { get; set; }
    }
}
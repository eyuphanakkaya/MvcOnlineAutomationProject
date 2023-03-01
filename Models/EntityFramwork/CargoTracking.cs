using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class CargoTracking
    {
        [Key]
        public int CargoTrackingId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(10)]
        public string StarckingCode { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength (100)]
        public string Explanation { get; set; }
        public DateTime DateTime { get; set; }

    }
}
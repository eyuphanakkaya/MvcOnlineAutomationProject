using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class Detail:Entity
    {
        [Key]
        public int DetailId { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(30)]
        public string DetailProductName { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength (2000)]
        public string DetailProductExplanation { get; set; }
    }
}
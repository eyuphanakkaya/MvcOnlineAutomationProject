using MvcOnlineAutomationProject.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sender { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Subject { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(3000)]
        public string Contents { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineAutomationProject.Models.EntityFramwork
{
    public class ToDo:Entity
    {
        [Key]
        public int ToDoId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(100)]
        public string Title { get; set; }
        [Column(TypeName="bit")]
        public bool Status { get; set; }
    }
}
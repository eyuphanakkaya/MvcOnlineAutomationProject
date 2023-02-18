using MvcOnlineAutomationProject.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomationProject.Models.EntityFramework
{
    public class SalesMovement:Entity
    {
        [Key]
        public int SalesMovementsId { get; set; }
        public DateTime Date { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public int Productid { get; set; }
        public int Currentid { get; set; }
        public int Employeeid { get; set; }
        public virtual Product Product { get; set; }
        public virtual Current Current { get; set; }
        public virtual Employee Employee { get; set; }

    }
}

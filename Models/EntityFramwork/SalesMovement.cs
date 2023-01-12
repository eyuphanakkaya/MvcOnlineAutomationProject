using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class SalesMovement
    {
        [Key]
        public int SalesMovementsId { get; set; }
        public DateTime Date { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public Product Product { get; set; }
        public Current Current { get; set; }
        public Employee Employee { get; set; }

    }
}

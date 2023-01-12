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
        public ICollection<Product> Products { get; set; }
        public ICollection<Current> Currents { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}

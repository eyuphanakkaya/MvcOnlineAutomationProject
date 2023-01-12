using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public bool Status { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }
        public Category Category { get; set; }//bir ürünümün birden fazla kategorisi olamaz
        public SalesMovement SalesMovement { get; set; }
    }
}

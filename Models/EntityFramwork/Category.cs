using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }//her kategoride birden fazla ürün olabilir
    }
}

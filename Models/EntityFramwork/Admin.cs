using MvcOnlineAutomationProject.Models.EntityFramwork;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomationProject.Models.EntityFramework
{
    public class Admin:Entity
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string UseName { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string Official { get; set; }


    }
}

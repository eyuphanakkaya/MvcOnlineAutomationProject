using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class Current
    {
        [Key]
        public int CurrentId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurremtName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurremtSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CurremtCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentEmail { get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }

    }
}

using MvcOnlineAutomationProject.Models.EntityFramwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace MvcOnlineAutomationProject.Models.EntityFramework
{
    public class Current:Entity
    {
        [Key]
        public int CurrentId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CurrentCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentEmail { get; set; }
        public bool Status { get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }

    }
}

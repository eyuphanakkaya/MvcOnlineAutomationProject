using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class Departmant
    {
        [Key]
        public int DepartmantId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmantName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

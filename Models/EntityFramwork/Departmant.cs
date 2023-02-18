
using MvcOnlineAutomationProject.Models.EntityFramwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomationProject.Models.EntityFramework
{
    public class Departmant:Entity
    {
        [Key]
        public int DepartmantId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmantName { get; set; }
        public bool Status { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}

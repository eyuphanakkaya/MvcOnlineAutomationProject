using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.EntityFramework
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string EmployeeImage { get; set; }
        public SalesMovement SalesMovement { get; set; }
        public Departmant Departmant { get; set; }
    }
}

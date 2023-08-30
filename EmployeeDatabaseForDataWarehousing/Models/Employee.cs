using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeDatabaseForDataWarehousing.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Emp_id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public decimal Experience { get; set; }
        public string Skills { get; set; }

        [ForeignKey(nameof(Address))]
        public int Address_id { get; set; }

        [ForeignKey(nameof(Project))]
        public int Project_id { get; set; }

        [ForeignKey(nameof(Manager))]
        public int Manager_id { get; set; }
    }
}


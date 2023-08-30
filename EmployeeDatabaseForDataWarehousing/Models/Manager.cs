using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeDatabaseForDataWarehousing.Models
{
    public class Manager
    {
        [Key]
        [Required]
        public int Manager_id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Experience { get; set; }
        public decimal Salary { get; set; }
        public string Skills { get; set; }

        [ForeignKey(nameof(Project))]
        public int Project_id { get; set; }
    }
}


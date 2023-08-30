using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeDatabaseForDataWarehousing.Models
{
    public class Project
    {
        [Key]
        public int Project_id { get; set; }
        public string Name { get; set; }
        public decimal Duration { get; set; }

        [ForeignKey(nameof(Company))]
        public int Company_id { get; set; }
    }
}


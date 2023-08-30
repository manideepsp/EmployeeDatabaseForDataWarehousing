using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeDatabaseForDataWarehousing.Models
{
    public class Company
    {
        [Key]
        public int Company_id { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public decimal Revenue { get; set; }
        public decimal Age { get; set; }
        public int N_employees { get; set; }

        [ForeignKey(nameof(Address))]
        public int Address_id { get; set; }
    }
}


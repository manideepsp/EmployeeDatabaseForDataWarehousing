using System.ComponentModel.DataAnnotations;
namespace EmployeeDatabaseForDataWarehousing.Models
{
    public class Address
    {
        [Key]
        public int Address_id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}


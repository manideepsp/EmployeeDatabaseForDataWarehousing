using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeDatabaseForDataWarehousing.Models;

namespace EmployeeDatabaseForDataWarehousing.Data
{
    public class EmployeeDatabaseForDataWarehousingContext : DbContext
    {
        public EmployeeDatabaseForDataWarehousingContext (DbContextOptions<EmployeeDatabaseForDataWarehousingContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeDatabaseForDataWarehousing.Models.Employee> Employee { get; set; } = default!;

        public DbSet<EmployeeDatabaseForDataWarehousing.Models.Manager> Manager { get; set; } = default!;

        public DbSet<EmployeeDatabaseForDataWarehousing.Models.Project> Project { get; set; } = default!;

        public DbSet<EmployeeDatabaseForDataWarehousing.Models.Address> Address { get; set; } = default!;

        public DbSet<EmployeeDatabaseForDataWarehousing.Models.Company> Company { get; set; } = default!;
    }
}

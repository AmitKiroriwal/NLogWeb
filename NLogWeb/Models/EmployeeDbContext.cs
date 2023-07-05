using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NLogWeb.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<States> states { get; set; }
        public DbSet<Districts> districts { get; set; }
        public DbSet<Cities> cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}

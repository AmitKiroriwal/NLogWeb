using Microsoft.EntityFrameworkCore;
using NLogWeb.Models;

namespace NLogWeb.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                Id = 1,
                Name="Amit",
                Email="amit@sircltech.com", 
                Department=Dept.Development,
                Job="Software",
                Salary=50000,
                HireDate=DateTime.Now
            },
            new Employee()
            {
                Id = 2,
                Name = "Sunil",
                Email = "Sunil@sircltech.com",
                Department = Dept.IT,
                Job = "Hardware",
                Salary = 40000,
                HireDate =Convert.ToDateTime("2022-01-01")
            }
            );
            //modelBuilder.Entity<MyGallery>().HasData(new MyGallery());
        }
    }
}

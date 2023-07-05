using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NLogWeb.Models;

namespace NLogWeb.Models
{
    public class EmployeeMySqlRepo : IEmployeeRepository
    {
        private readonly EmployeeDbContext context;
        

        public EmployeeMySqlRepo(EmployeeDbContext context)
        {
            this.context = context; //DI
         
        }
        public Employee AddEmployee(Employee employee)
        {
            context.employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee=context.employees.Find(id);
            if(employee!=null)
            {
                context.employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public List<Employee> GetAllEmployee()
        {
            return context.employees.ToList();
        }

        public Employee GetEmployee(int Id)
        {
           
            return context.employees.FirstOrDefault(x => x.Id == Id);
        }

        public async Task<IEnumerable<SelectListItem>> statelist()
        {
            var data = context.states.Select(S => new { Name = S.StateName, id = S.StateId });
            var res = await data.Select(x => new SelectListItem { Text = x.Name, Value = x.id.ToString() }).ToListAsync();
            return res;
        }
        public async Task<IEnumerable<SelectListItem>> District(int id)
        {
            var data = context.districts.Where(x => x.StateId == id).Select(s => new {Name= s.Name, id = s.Id });
            var res = await data.Select(x => new SelectListItem { Text = x.Name, Value = x.id.ToString() }).ToListAsync();
            return res;
        }
        public async Task<IEnumerable<SelectListItem>> Cities(int id)
        {
            var data = context.cities.Where(x => x.StateId == id).Select(s => new { Name = s.CityName, id = s.CityId });
            var res = await data.Select(x => new SelectListItem { Text = x.Name, Value = x.id.ToString() }).ToListAsync();
            return res;
        }

        public Employee UpdateEmployee(Employee employee)
        {

          
                var Employee = context.employees.Attach(employee);
                Employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            
            
            return employee;
        }
    }
}

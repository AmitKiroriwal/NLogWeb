using Microsoft.AspNetCore.Mvc.Rendering;

namespace NLogWeb.Models
{
    public interface IEmployeeRepository
    {
       public Employee GetEmployee(int Id);
        public List<Employee> GetAllEmployee();
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int id);
        Task<IEnumerable<SelectListItem>> statelist();
        Task<IEnumerable<SelectListItem>> District(int id);
        Task<IEnumerable<SelectListItem>> Cities(int id);
    }
}

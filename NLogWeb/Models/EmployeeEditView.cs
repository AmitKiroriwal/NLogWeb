using NLogWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace NLogWeb.Models
{
    public class EmployeeEditView
    {
        public string Name { get; set; }


      
        public string Email { get; set; }

        public Dept? Department { get; set; }
    }
}

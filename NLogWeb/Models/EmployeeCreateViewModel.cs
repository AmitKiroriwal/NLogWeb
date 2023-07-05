using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NLogWeb.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace NLogWeb.Models
{
    public class EmployeeCreateViewModel
    {
        States state=new States();
        Cities city=new Cities();
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2)]
        [Required, MaxLength(50, ErrorMessage = "Name Cannot Exceed 50 Characters")]
        public string Name { get; set; }

        [Column(Order = 3)]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }
        [Column(Order = 4, TypeName ="date")]
        public DateTime HireDate { get; set; }

        [Column(Order = 5, TypeName = "nvarchar(50)")]
        public string Job { get; set; }

        [Column(Order = 6, TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        [Column(Order = 7)]
        [Required(ErrorMessage = "Department Field is Required")]

        public Dept? Department { get; set; }
        [Column(Order = 8, TypeName = "date")]
        public DateTime AddOn { get; set; } = DateTime.Now;
        [Column(Order = 9, TypeName = "date")]
        public DateTime UpdateOn { get; set; } = DateTime.Now;
        [Column(Order = 10)]
        public Status RecStatus { get; set; } = Status.Active;
        public string States { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public IFormFile Photo { get; set; }
    }
}

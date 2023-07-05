using System.ComponentModel.DataAnnotations;

namespace NLogWeb.Models
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}

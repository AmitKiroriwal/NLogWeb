using System.ComponentModel.DataAnnotations;

namespace NLogWeb.Models
{
    public class Districts
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
    }
}

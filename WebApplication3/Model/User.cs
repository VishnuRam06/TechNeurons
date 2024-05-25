using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

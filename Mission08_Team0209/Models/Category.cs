using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0209.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirstModel.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Password { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();
    }
}

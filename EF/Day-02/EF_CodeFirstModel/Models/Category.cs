using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirstModel.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [StringLength(200)]
        public string? Description { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();
    }
}

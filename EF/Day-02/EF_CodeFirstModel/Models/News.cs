using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirstModel.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = "";

        [StringLength(100)]
        public string? Brief { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime PublishDate { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int Cat_Id { get; set; }

        [Required]
        [ForeignKey("Author")]
        public int Auth_Id { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Author? Author { get; set; }
    }
}

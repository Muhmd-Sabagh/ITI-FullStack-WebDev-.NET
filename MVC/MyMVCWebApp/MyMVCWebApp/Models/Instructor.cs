using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMVCWebApp.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Img { get; set; } = "default.jpg";

        public int DeptId { get; set; }

        public int CrsId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Course Course { get; set; }
    }
}

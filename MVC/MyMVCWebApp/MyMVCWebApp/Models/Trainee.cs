using System.ComponentModel.DataAnnotations;

namespace MyMVCWebApp.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Img { get; set; } 

        public int DeptId { get; set; }

        public virtual Department Department { get; set; }

        public virtual List<CrsResult> CrsResults { get; set; } = new List<CrsResult>();
    }
}

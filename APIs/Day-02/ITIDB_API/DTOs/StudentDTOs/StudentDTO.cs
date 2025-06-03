#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ITIDB_API.DTOs.StudentDTOs
{
    public class StudentDTO
    {
        [Required]
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Address { get; set; }

        public int? Age { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyMVCWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Unique]
        [MaxLength(25)]
        public string Name { get; set; }

        [Range(50, 100)]
        public int Degree { get; set; }

        [Remote("ValidateMinDegree", "Courses", AdditionalFields = "Degree")]
        public int MinDegree { get; set; }

        [Remote("ValidateHours", "Courses")]
        public int Hours { get; set; }
        [Required(ErrorMessage = "The Department Field is Required!")]
        public int DeptId { get; set; }

        public virtual Department? Department { get; set; }

        public virtual List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public virtual List<CrsResult> CrsResults { get; set; } = new List<CrsResult>();
    }
}

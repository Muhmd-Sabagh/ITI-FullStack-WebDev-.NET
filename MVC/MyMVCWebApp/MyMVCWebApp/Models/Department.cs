using System.ComponentModel.DataAnnotations;

namespace MyMVCWebApp.Models
{
    public class Department
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ManagerName { get; set; }

        public virtual List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public virtual List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public virtual List<Course> Courses { get; set; } = new List<Course>();
    }
}

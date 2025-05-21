using System.ComponentModel.DataAnnotations;

namespace MyMVCWebApp.ViewModels
{
    public class TraineesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public int CoursesCount { get; set; }
        public string Image { get; set; }
    }
}

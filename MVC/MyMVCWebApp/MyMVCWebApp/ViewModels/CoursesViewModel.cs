using MyMVCWebApp.Models;

namespace MyMVCWebApp.ViewModels
{
    public class CoursesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public int TraineesCount { get; set; }
    }
}

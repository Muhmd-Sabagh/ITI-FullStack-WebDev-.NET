namespace MyMVCWebApp.ViewModels
{
    public class CourseDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int Hours { get; set; }
        public string DepartmentName { get; set; }
        public List<CourseTraineeViewModel> Trainees { get; set; } = new List<CourseTraineeViewModel>();
    }
}

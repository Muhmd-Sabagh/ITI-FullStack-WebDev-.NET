namespace MyMVCWebApp.ViewModels
{
    public class TraineeDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public string DepartmentName { get; set; }
        public List<TraineeCourseViewModel> Courses { get; set; } = new List<TraineeCourseViewModel>();
    }
}

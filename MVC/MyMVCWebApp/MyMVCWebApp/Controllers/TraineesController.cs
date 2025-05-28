using Microsoft.AspNetCore.Mvc;
using MyMVCWebApp.Repository;
using MyMVCWebApp.ViewModels;

namespace MyMVCWebApp.Controllers
{
    public class TraineesController : Controller
    {
        ITraineeRepository traineeRepo;

        public TraineesController(ITraineeRepository _traineeRepo)
        {
            traineeRepo = _traineeRepo;
        }
        public IActionResult Index()
        {
            var trainees = traineeRepo.GetAll();
            if (trainees == null)
                return NotFound();

            var traineesVM = trainees
                .Select(t => new TraineesViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    DepartmentName = t.Department.Name,
                    CoursesCount = t.CrsResults.Count,
                    Image = t.Img
                })
                .ToList();

            return View(traineesVM);
        }

        public IActionResult Details(int id)
        {
            var trainee = traineeRepo.GetById(id);

            if (trainee == null)
            {
                return NotFound();
            }

            var traineeVM = new TraineeDetailsViewModel
            {
                Id = trainee.Id,
                Name = trainee.Name,
                Address = trainee.Address,
                ImagePath = trainee.Img,
                DepartmentName = trainee.Department?.Name,
                Courses = trainee.CrsResults.Select(cr => new TraineeCourseViewModel
                {
                    CourseName = cr.Course.Name,
                    MinDegree = cr.Course.MinDegree,
                    TraineeDegree = cr.Degree,
                    Passed = cr.Degree >= cr.Course.MinDegree
                }).ToList()
            };

            return View(traineeVM);
        }
    }
}

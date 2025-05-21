using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;
using MyMVCWebApp.ViewModels;

namespace MyMVCWebApp.Controllers
{
    public class TraineesController : Controller
    {
        ITIDBContext itiDb = new ITIDBContext();
        public IActionResult Index()
        {
            var trainees = itiDb.Trainees
                .Include(t => t.Department)
                .Include(t => t.CrsResults)
                .Select(t => new TraineesViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    DepartmentName = t.Department.Name,
                    CoursesCount = t.CrsResults.Count,
                    Image = t.Img
                })
                .ToList();

            if (trainees == null)
                return NotFound();
            return View(trainees);
        }

        public IActionResult Details(int id)
        {
            var trainee = itiDb.Trainees
                .Include(t => t.Department)
                .Include(t => t.CrsResults)
                    .ThenInclude(cr => cr.Course)
                .FirstOrDefault(t => t.Id == id);

            if (trainee == null)
            {
                return NotFound();
            }

            var traineeViewModel = new TraineeDetailsViewModel
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

            return View(traineeViewModel);
        }
    }
}

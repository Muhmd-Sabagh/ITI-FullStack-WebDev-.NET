using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;
using MyMVCWebApp.ViewModels;

namespace MyMVCWebApp.Controllers
{
    public class CoursesController : Controller
    {
        ITIDBContext itiDb = new ITIDBContext();
        public IActionResult Index()
        {
            var courses = itiDb.Courses
                .Include(c => c.Department)
                .Include(c => c.CrsResults)
                .Select(c => new CoursesViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    DepartmentName = c.Department.Name,
                    TraineesCount = c.CrsResults.Count
                })
                .ToList();

            if (courses == null)
                return NotFound();
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = itiDb.Courses
                .Include(c => c.Department)
                .Include(c => c.CrsResults)
                    .ThenInclude(cr => cr.Trainee)
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            var courseViewModel = new CourseDetailsViewModel
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                Hours = course.Hours,
                DepartmentName = course.Department.Name,
                Trainees = course.CrsResults.Select(cr => new CourseTraineeViewModel
                {
                    Image = cr.Trainee.Img,
                    TraineeName = cr.Trainee.Name,
                    Degree = cr.Degree,
                    Passed = cr.Degree >= course.MinDegree
                }).ToList()
            };

            return View(courseViewModel);
        }
    }
}

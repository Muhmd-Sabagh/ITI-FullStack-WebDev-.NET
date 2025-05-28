using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyMVCWebApp.Models;
using MyMVCWebApp.Repository;
using MyMVCWebApp.ViewModels;

namespace MyMVCWebApp.Controllers
{
    public class CoursesController : Controller
    {
        ICourseRepository courseRepo;
        IDepartmentRepository deptRepo;
        public CoursesController(ICourseRepository _courseRepo, IDepartmentRepository _deptRepo)
        {
            courseRepo = _courseRepo;
            deptRepo = _deptRepo;
        }
        // GET: Courses
        public IActionResult Index()
        {
            var courses = courseRepo.GetAll();
            if (courses == null)
                return NotFound();

            var coursesVM = courses
                .Select(c => new CoursesViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    DepartmentName = c.Department.Name,
                    TraineesCount = c.CrsResults.Count
                }).ToList();

            return View(coursesVM);
        }

        // GET: Courses/Details/@id
        public IActionResult Details(int id)
        {
            Course? course = courseRepo.GetById(id);

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

        // GET: Courses/Add
        public IActionResult Add()
        {
            ViewBag.Departments = new SelectList(deptRepo.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Courses/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveAdd(Course course)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    courseRepo.Add(course);
                    courseRepo.Save();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("NewError", ex.InnerException?.Message ?? "There is an error adding this course!");
                }
            }

            ViewBag.Departments = new SelectList(deptRepo.GetAll(), "Id", "Name");
            return View("Add", course);
        }

        // Min Degree Validation (has to be lower than degree)
        public IActionResult ValidateMinDegree(int minDegree, int degree)
        {
            if (minDegree >= degree)
                return Json($"Minimum Degree Must be Lower Than Degree ({degree})!");
            else
                return Json(true);
        }

        // Hours Validation (has to be divided by 3)
        public IActionResult ValidateHours(int hours)
        {
            if (hours % 3 != 0)
                return Json("Hours Must be Divided by 3");
            else
                return Json(true);
        }
    }
}

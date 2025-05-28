using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;
using MyMVCWebApp.Repository;

namespace MyMVCWebApp.Controllers
{
    public class InstructorsController : Controller
    {
        IInstructorRepository instructorRepo;
        IDepartmentRepository deptRepo;
        ICourseRepository courseRepo;

        public InstructorsController(IInstructorRepository _instructorRepo, IDepartmentRepository _deptRepo, ICourseRepository _courseRepo)
        {
            instructorRepo = _instructorRepo;
            deptRepo = _deptRepo;
            courseRepo = _courseRepo;
        }
        // GET: Instructors
        public IActionResult Index()
        {
            var instructors = instructorRepo.GetAll();

            if (instructors != null)
                return View(instructors);
            return NotFound();
        }

        // GET: Instructors/Details/@id
        public IActionResult Details(int id)
        {
            var instructor = instructorRepo.GetById(id);

            if (instructor != null)
                return View("Details", instructor);
            return NotFound();
        }

        // GET: Instructors/Add
        public IActionResult Add()
        {
            ViewBag.Departments = new SelectList(deptRepo.GetAll(), "Id", "Name");
            ViewBag.Courses = new SelectList(courseRepo.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Instructors/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Instructor instructor)
        {
            if (string.IsNullOrEmpty(instructor.Name) ||
                instructor.Salary <= 0 ||
                string.IsNullOrEmpty(instructor.Address) ||
                instructor.DeptId == 0 ||
                instructor.CrsId == 0)
            {
                // Reload dropdowns if validation fails
                ViewBag.Departments = new SelectList(deptRepo.GetAll(), "Id", "Name", instructor.DeptId);
                ViewBag.Courses = new SelectList(deptRepo.GetAll(), "Id", "Name", instructor.CrsId);
                return View(instructor);
            }

            // Set default image if none provided
            if (string.IsNullOrEmpty(instructor.Img))
            {
                instructor.Img = "default.jpg";
            }

            instructorRepo.Add(instructor);
            instructorRepo.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Controllers
{
    public class InstructorsController : Controller
    {
        readonly ITIDBContext itiDb = new ITIDBContext();

        // GET: Instructors
        public IActionResult Index()
        {
            var instructors = itiDb.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .ToList();

            if (instructors != null)
                return View(instructors);
            return NotFound();
        }

        // GET: Instructors/Details/@id
        public IActionResult Details(int id)
        {
            var instructor = itiDb.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .FirstOrDefault(i => i.Id == id);

            if (instructor != null)
                return View("Details", instructor);
            return NotFound();
        }

        // GET: Instructors/Add
        public IActionResult Add()
        {
            ViewBag.Departments = new SelectList(itiDb.Departments, "Id", "Name");
            ViewBag.Courses = new SelectList(itiDb.Courses, "Id", "Name");
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
                ViewBag.Departments = new SelectList(itiDb.Departments, "Id", "Name", instructor.DeptId);
                ViewBag.Courses = new SelectList(itiDb.Courses, "Id", "Name", instructor.CrsId);
                return View(instructor);
            }

            // Set default image if none provided
            if (string.IsNullOrEmpty(instructor.Img))
            {
                instructor.Img = "default.jpg";
            }

            itiDb.Instructors.Add(instructor);
            itiDb.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

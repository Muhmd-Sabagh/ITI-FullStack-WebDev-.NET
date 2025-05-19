using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Controllers
{
    public class InstructorsController : Controller
    {
        static ITIDBContext itiDb = new ITIDBContext();
        List<Instructor> instructors = itiDb.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course).ToList();
        public IActionResult Index()
        {
            if (instructors != null)
                return View(instructors);
            return NotFound();
        }

        public IActionResult Details(int id)
        {
            Instructor? instructor = instructors.SingleOrDefault(i=>i.Id== id);
            if (instructor != null)
                return View("Details", instructor);
            return NotFound();
        }
    }
}

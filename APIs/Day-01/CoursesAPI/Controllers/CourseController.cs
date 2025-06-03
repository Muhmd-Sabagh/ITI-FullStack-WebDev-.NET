using Microsoft.AspNetCore.Mvc;
using CoursesAPI.Repository;
using CoursesAPI.Models;

namespace CoursesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseRepository courseRepo;
        public CourseController(ICourseRepository _courseRepo)
        {
            courseRepo = _courseRepo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            List<Course>? courses = courseRepo.GetAll();
            return courses == null ? NotFound() : Ok(courses);
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            if(courseRepo.GetById(id) == null)
                return NotFound();
            return Ok(courseRepo.GetById(id));
        }

        [HttpGet("{name:alpha}")]
        public ActionResult GetByName(string name)
        {
            if (courseRepo.GetByName(name) == null)
                return NotFound();
            return Ok(courseRepo.GetByName(name));
        }

        [HttpPost]
        public ActionResult Post(Course c)
        {
            if(c == null)
                return BadRequest();
            courseRepo.Add(c);
            courseRepo.Save();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(int id, Course c)
        {
            if (id != c.ID) return BadRequest();
            if (courseRepo.GetById(id) == null) return NotFound();
            courseRepo.Update(c);
            courseRepo.Save();
            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteCourse(int id)
        {
            if (courseRepo.GetById(id) == null) return NotFound();
            courseRepo.DeleteById(id);
            courseRepo.Save();
            return Ok(courseRepo.GetAll());
        }
    }
}

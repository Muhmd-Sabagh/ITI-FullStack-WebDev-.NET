using CoursesAPI.Models;
using CoursesAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoursesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartmentRepository deptRepo;
        public DepartmentController(IDepartmentRepository _deptRepo)
        {
            deptRepo = _deptRepo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            List<Department> departments = deptRepo.GetAll();
            return departments == null ? NotFound() : Ok(departments);
        }
    }
}

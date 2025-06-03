using AutoMapper;
using ITIDB_API.DTOs.DepartmentDTOs;
using ITIDB_API.Models;
using ITIDB_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ITIDB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository DepartmentRepo;
        private readonly IMapper Mapper;
        public DepartmentController(IDepartmentRepository departmentRepo, IMapper mapper)
        {
            DepartmentRepo = departmentRepo;
            Mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Department>? departments = DepartmentRepo.GetAll();
            List<DisplayDepartmentDTO> departmentsData = Mapper.Map<List<DisplayDepartmentDTO>>(departments);
            return departments == null ? NotFound() : Ok(departmentsData);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Department? dept = DepartmentRepo.GetById(id);
            if (dept == null) return NotFound();
            return Ok(Mapper.Map<DisplayDepartmentDTO>(dept));
        }

        [HttpPost]
        public IActionResult Insert(AddDepartmentDTO addDeptDTO)
        {
            if (addDeptDTO == null || !ModelState.IsValid) return BadRequest();

            Department? insertedDept = DepartmentRepo.InsertAndReturn(Mapper.Map<Department>(addDeptDTO));
            return Ok(Mapper.Map<DisplayDepartmentDTO>(insertedDept));
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, AddDepartmentDTO newDeptDTO)
        {
            Department? department = DepartmentRepo.GetById(id);
            if (department == null || newDeptDTO == null) return BadRequest();

            DisplayDepartmentDTO oldDept = Mapper.Map<DisplayDepartmentDTO>(department);
            Mapper.Map(newDeptDTO, department);
            DepartmentRepo.Update(department);
            DepartmentRepo.Save();
            return Ok(new
            {
                Befor = oldDept,
                After = Mapper.Map<DisplayDepartmentDTO>(department)
            });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (DepartmentRepo.GetById(id) == null) return NotFound();
            DepartmentRepo.DeleteById(id);
            DepartmentRepo.Save();
            return GetAll();
        }
    }
}

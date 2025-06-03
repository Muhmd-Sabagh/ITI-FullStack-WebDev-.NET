using ITIDB_API.Repositories;
using ITIDB_API.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ITIDB_API.DTOs.StudentDTOs;

namespace ITIDB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository StudentRepo;
        private readonly IMapper Mapper;
        public StudentController(IStudentRepository studentRepo, IMapper mapper)
        {
            StudentRepo = studentRepo;
            Mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Student>? students = StudentRepo.GetAll();
            List<DisplayStudentDTO> studentsData = Mapper.Map<List<DisplayStudentDTO>>(students);
            return students == null ? NotFound() : Ok(studentsData);
        }

        [HttpGet("page")]
        public IActionResult GetPaginated([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            List<Student> students = StudentRepo.GetPaginated(pageNumber, pageSize, out int totalCount);
            if (!students.Any()) return NotFound();

            List<DisplayStudentDTO> studentDTOs = Mapper.Map<List<DisplayStudentDTO>>(students);

            return Ok(new
            {
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Data = studentDTOs
            });
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Student? st = StudentRepo.GetById(id);
            if (st == null) return NotFound();
            return Ok(Mapper.Map<DisplayStudentDTO>(st));
        }

        [HttpGet("search")]
        public IActionResult SearchByName([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Search term is required.");

            var students = StudentRepo.SearchByName(name);
            var studentsDTO = Mapper.Map<List<DisplayStudentDTO>>(students);
            return Ok(studentsDTO);
        }

        [HttpPost]
        public IActionResult Insert(AddStudentDTO addStDTO)
        {
            if (addStDTO == null || !ModelState.IsValid) return BadRequest();

            Student? insertedSt = StudentRepo.InsertAndReturn(Mapper.Map<Student>(addStDTO));
            return Ok(Mapper.Map<DisplayStudentDTO>(insertedSt));
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, AddStudentDTO newStDTO)
        {
            Student? student = StudentRepo.GetById(id);
            if (student == null || newStDTO == null) return BadRequest();

            DisplayStudentDTO oldSt = Mapper.Map<DisplayStudentDTO>(student);
            Mapper.Map(newStDTO, student);
            StudentRepo.Update(student);
            StudentRepo.Save();
            return Ok(new 
            {
                Befor = oldSt,
                After = Mapper.Map<DisplayStudentDTO>(student) 
            });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (StudentRepo.GetById(id) == null) return NotFound();
            StudentRepo.DeleteById(id);
            StudentRepo.Save();
            return GetAll();
        }
    }
}

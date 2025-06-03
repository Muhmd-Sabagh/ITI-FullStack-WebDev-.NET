#nullable disable
namespace ITIDB_API.DTOs.StudentDTOs
{
    public class AddStudentDTO : StudentDTO
    {
        public int? Dept_Id { get; set; }
        public int? Super_Id { get; set; }
    }
}

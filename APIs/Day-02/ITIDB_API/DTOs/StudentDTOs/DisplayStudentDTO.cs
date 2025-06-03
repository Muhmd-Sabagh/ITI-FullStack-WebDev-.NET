#nullable disable
namespace ITIDB_API.DTOs.StudentDTOs
{
    public class DisplayStudentDTO : StudentDTO
    {
        public int Id { get; set; }
        public string Dept_Name { get; set; }
        public string Super_Name { get; set; }
    }
}

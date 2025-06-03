#nullable disable
namespace ITIDB_API.DTOs.DepartmentDTOs
{
    public class DisplayDepartmentDTO : DepartmentDTO
    {
        public int Dept_Id { get; set; }
        public string Manager_Name { get; set; }
        public int StCount { get; set; }
    }
}

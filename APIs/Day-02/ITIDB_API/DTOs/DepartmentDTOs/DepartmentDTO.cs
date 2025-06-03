#nullable disable
namespace ITIDB_API.DTOs.DepartmentDTOs
{
    public class DepartmentDTO
    {
        public string Dept_Name { get; set; }
        public string Dept_Desc { get; set; }
        public string Dept_Location { get; set; }
        public DateTime? Manager_hiredate { get; set; }
    }
}

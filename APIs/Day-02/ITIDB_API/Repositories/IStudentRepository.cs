using ITIDB_API.Models;

namespace ITIDB_API.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        // Additional Methods
        Student? InsertAndReturn(Student student);
        List<Student> GetPaginated(int pageNumber, int pageSize, out int totalCount);
        List<Student> SearchByName(string name);
    }
}

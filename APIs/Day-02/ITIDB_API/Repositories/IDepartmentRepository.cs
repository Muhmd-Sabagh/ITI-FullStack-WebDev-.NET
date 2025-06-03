using ITIDB_API.Models;

namespace ITIDB_API.Repositories
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        // Additional Methods
        Department? InsertAndReturn(Department department);
    }
}

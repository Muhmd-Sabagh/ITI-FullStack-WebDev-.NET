using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ITIDBContext context;
        public DepartmentRepository(ITIDBContext _context)
        {
            context = _context;
        }
        public void Add(Department obj)
        {
            context.Add(obj);
        }

        public void DeleteById(int id)
        {
            context.Departments.Remove(GetById(id));
        }

        public List<Department>? GetAll()
        {
            return context.Departments.AsNoTracking().ToList();
        }

        public Department? GetById(int id)
        {
            return context.Departments
                .FirstOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department obj)
        {
            Department prevDept = GetById(obj.Id);
            prevDept.Name = obj.Name;
            prevDept.ManagerName = obj.ManagerName;
        }
    }
}

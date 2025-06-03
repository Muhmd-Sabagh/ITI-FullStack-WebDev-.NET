using ITIDB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIDB_API.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ITIContext context;
        public DepartmentRepository(ITIContext _context)
        {
            context = _context;
        }
        public void DeleteById(int id)
        {
            Department deletedDept = GetById(id) ?? throw new Exception("Department Not Found!");
            context.Departments.Remove(deletedDept);
        }

        public List<Department>? GetAll()
        {
            return context.Departments.ToList();
        }

        public Department? GetById(int id)
        {
            return context.Departments.FirstOrDefault(d => d.Dept_Id == id);
        }

        public void Insert(Department entity)
        {
            context.Departments.Add(entity);
        }

        public Department? InsertAndReturn(Department department)
        {
            context.Departments.Add(department);
            Save();

            return context.Departments
                .Include(d => d.Dept_ManagerNavigation)
                .FirstOrDefault(d => d.Dept_Id == department.Dept_Id)!;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}

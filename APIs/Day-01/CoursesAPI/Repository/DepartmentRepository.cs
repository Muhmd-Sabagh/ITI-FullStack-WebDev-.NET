using CoursesAPI.Models;

namespace CoursesAPI.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CoursesContext context;
        public DepartmentRepository(CoursesContext _context)
        {
            context = _context;
        }
        public void Add(Department obj)
        {
            context.Departments.Add(obj);
        }

        public void DeleteById(int id)
        {
            if (GetById(id) == null)
                throw new Exception("Course Not Found!");
            else
                context.Departments.Remove(GetById(id));
        }

        public List<Department>? GetAll()
        {
            return context.Departments.ToList();
        }

        public Department? GetById(int id)
        {
            return context.Departments.FirstOrDefault(c => c.ID == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}

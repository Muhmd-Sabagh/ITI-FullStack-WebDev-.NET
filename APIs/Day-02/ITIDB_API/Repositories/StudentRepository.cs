using ITIDB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIDB_API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ITIContext context;
        public StudentRepository(ITIContext _context)
        {
            context = _context;
        }
        public void DeleteById(int id)
        {
            Student deletedSt = GetById(id) ?? throw new Exception("Student Not Found!");
            context.Students.Remove(deletedSt);
        }

        public List<Student>? GetAll()
        {
            return context.Students.ToList();
        }

        public Student? GetById(int id)
        {
            return context.Students.FirstOrDefault(s => s.St_Id == id);
        }

        public List<Student> GetPaginated(int pageNumber, int pageSize, out int totalCount)
        {
            var query = context.Students
                .Include(s => s.Dept)
                .Include(s => s.St_superNavigation)
                .AsQueryable();

            totalCount = query.Count();

            return query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public List<Student> SearchByName(string name)
        {
            return context.Students
                .Include(s => s.Dept)
                .Include(s => s.St_superNavigation)
                .Where(s => s.St_Fname.Contains(name) || s.St_Lname.Contains(name))
                .ToList();
        }

        public void Insert(Student entity)
        {
            context.Students.Add(entity);
        }

        public Student? InsertAndReturn(Student student)
        {
            context.Students.Add(student);
            Save();

            return context.Students
                .Include(s => s.Dept)
                .Include(s => s.St_superNavigation)
                .FirstOrDefault(s => s.St_Id == student.St_Id)!;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Student entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}

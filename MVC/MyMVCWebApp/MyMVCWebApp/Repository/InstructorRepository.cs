using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly ITIDBContext context;
        public InstructorRepository(ITIDBContext _context)
        {
            context = _context;
        }
        public void Add(Instructor obj)
        {
            context.Instructors.Add(obj);
        }

        public void DeleteById(int id)
        {
            context.Instructors.Remove(GetById(id));
        }

        public List<Instructor>? GetAll()
        {
            return context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .AsNoTracking()
                .ToList();
        }

        public Instructor? GetById(int id)
        {
            return context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .FirstOrDefault(i => i.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Instructor obj)
        {
            Instructor prevInstructor = GetById(obj.Id);
            prevInstructor.Name = obj.Name;
            prevInstructor.Address = obj.Address;
            prevInstructor.Salary = obj.Salary;
            prevInstructor.Img = obj.Img;
            prevInstructor.DeptId = obj.DeptId;
            prevInstructor.CrsId = obj.CrsId;
        }
    }
}

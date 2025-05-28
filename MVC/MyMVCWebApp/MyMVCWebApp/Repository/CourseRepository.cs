using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ITIDBContext context;
        public CourseRepository(ITIDBContext _context)
        {
            context = _context;
        }
        public void Add(Course obj)
        {
            context.Courses.Add(obj);
        }

        public void DeleteById(int id)
        {
            context.Courses.Remove(GetById(id));
        }

        public List<Course>? GetAll()
        {
            return context.Courses
                .Include(c => c.Department)
                .Include(c => c.CrsResults)
                    .ThenInclude(cr => cr.Trainee)
                    .AsNoTracking()
                    .ToList();
        }

        public Course? GetById(int id)
        {
            return context.Courses
                .Include(c => c.Department)
                .Include(c => c.CrsResults)
                    .ThenInclude(cr => cr.Trainee)
                    .FirstOrDefault(c => c.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Course obj)
        {
            Course prevCourse = GetById(obj.Id);
            prevCourse.Name = obj.Name;
            prevCourse.Hours = obj.Hours;
            prevCourse.Degree = obj.Degree;
            prevCourse.MinDegree = obj.MinDegree;
            prevCourse.DeptId = obj.DeptId;
        }
    }
}

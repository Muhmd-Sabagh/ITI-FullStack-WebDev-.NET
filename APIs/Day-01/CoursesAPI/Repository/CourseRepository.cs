using CoursesAPI.Models;

namespace CoursesAPI.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CoursesContext context;
        public CourseRepository(CoursesContext _context)
        {
            context = _context;
        }
        public void Add(Course obj)
        {
            context.Courses.Add(obj);
        }

        public void DeleteById(int id)
        {
            Course? deletedSt = GetById(id);
            if (deletedSt == null)
                throw new Exception("Student Not Found!");
            context.Courses.Remove(deletedSt);
        }

        public List<Course>? GetAll()
        {
            return context.Courses.ToList();
        }

        public Course? GetById(int id)
        {
            return context.Courses.FirstOrDefault(c => c.ID == id);
        }

        public Course? GetByName(string name)
        {
            return context.Courses.FirstOrDefault(c => c.Crs_Name.ToLower() == name.ToLower());
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Course obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}

using CoursesAPI.Models;

namespace CoursesAPI.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        // Additional Methods
        Course? GetByName(string name);
    }
}

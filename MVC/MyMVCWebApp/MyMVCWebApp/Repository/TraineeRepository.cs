using Microsoft.EntityFrameworkCore;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Repository
{
    public class TraineeRepository : ITraineeRepository
    {
        private readonly ITIDBContext context;
        public TraineeRepository(ITIDBContext _context)
        {
            context = _context;
        }
        public void Add(Trainee obj)
        {
            context.Trainees.Add(obj);
        }

        public void DeleteById(int id)
        {
            context.Trainees.Remove(GetById(id));
        }

        public List<Trainee>? GetAll()
        {
            return context.Trainees
                .Include(t => t.Department)
                .Include(t => t.CrsResults)
                    .ThenInclude(cr=>cr.Course)
                    .ToList();
        }

        public Trainee? GetById(int id)
        {
            return context.Trainees
                .Include(t => t.Department)
                .Include(t => t.CrsResults)
                    .ThenInclude(cr => cr.Course)
                    .FirstOrDefault(t => t.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Trainee obj)
        {
            Trainee prevTrainee = GetById(obj.Id);
            prevTrainee.Name = obj.Name;
            prevTrainee.Address = obj.Address;
            prevTrainee.Img = obj.Img;
            prevTrainee.DeptId = obj.DeptId;
        }
    }
}

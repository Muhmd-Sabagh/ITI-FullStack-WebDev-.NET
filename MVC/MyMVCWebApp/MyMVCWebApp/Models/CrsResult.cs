using Microsoft.EntityFrameworkCore;

namespace MyMVCWebApp.Models
{
    [PrimaryKey(nameof(CrsId), nameof(TraineeId))]
    public class CrsResult
    {
        public int Degree { get; set; }

        public int CrsId { get; set; }

        public int TraineeId { get; set; }

        public virtual Course Course { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}

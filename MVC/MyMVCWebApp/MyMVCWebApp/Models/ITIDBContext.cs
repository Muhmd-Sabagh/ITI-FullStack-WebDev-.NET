using Microsoft.EntityFrameworkCore;

namespace MyMVCWebApp.Models
{
    public class ITIDBContext : DbContext
    {
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Instructor> Instructors { get; set; }

        public virtual DbSet<Trainee> Trainees { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MUHMD-SABAGH-PC\\SQLEXPRESS;Database=ITIDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DeptId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Course)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.CrsId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Trainee>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Trainees)
                .HasForeignKey(t => t.DeptId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DeptId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CrsResult>()
                .HasOne(cr => cr.Course)
                .WithMany(c => c.CrsResults)
                .HasForeignKey(cr => cr.CrsId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CrsResult>()
                .HasOne(cr => cr.Trainee)
                .WithMany(t => t.CrsResults)
                .HasForeignKey(cr => cr.TraineeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirstModel.Models
{
    class NewspaperContext : DbContext
    {
        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=MUHMD-SABAGH-PC\\SQLEXPRESS;Database=EFD02;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .HasOne(n => n.Category)
                .WithMany(c => c.News)
                .HasForeignKey(n => n.Cat_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<News>()
                .HasOne(n => n.Author)
                .WithMany(a => a.News)
                .HasForeignKey(n => n.Auth_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

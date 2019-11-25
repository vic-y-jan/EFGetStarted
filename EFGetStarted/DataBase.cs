using Microsoft.EntityFrameworkCore;
namespace EFGetStarted
{
    public class DataBase : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=team-db;Trusted_Connection=True;");
        }
    }
}

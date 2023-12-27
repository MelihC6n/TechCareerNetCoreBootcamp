using EntityFrameworkEntry.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkEntry.ORM
{
    public class TechCareerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-13V6IU8;Database=TechCareer;Trusted_Connection=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

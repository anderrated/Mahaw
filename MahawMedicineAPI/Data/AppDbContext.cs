using MahawMedicineAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MahawMedicineAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Email = "admin@mahaw.com",
                Password = PasswordHelper.HashPassword("admin123"),
                Role = "admin"
            });
        }
    }
}

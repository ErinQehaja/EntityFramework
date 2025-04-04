using Microsoft.EntityFrameworkCore;

namespace SmallAplicationWithEF
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> Items { get; set; }
        public DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydatabase.db");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SmallAplicationWithEF
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydatabase.db")
                .LogTo(
                Console.WriteLine,
                LogLevel.Information);
        }
    }
}
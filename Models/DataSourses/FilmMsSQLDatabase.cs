using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.DataSourses.Types;
using WebApplication1.Models.Types;

namespace WebApplication1.Models.DataSourses
{
    public class FilmMsSQLDatabase : DbContext
    {
        public DbSet<Film> films = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}

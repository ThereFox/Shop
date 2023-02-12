using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Types;

namespace WebApplication1.Models
{
    public class FilmDatabase : DbContext, IFilmDataSourse
    {
        private DbSet<Film> data = null!;

        public FilmDatabase()
        {

        }

        public Film GetFilm(int id)
        {
            throw new NotImplementedException();
        }

        public List<Film> GetFilms(int count, int page)
        {
            throw new NotImplementedException();
        }

        public List<Film> GetFilms(FilmFiltr filtrs, int count, int page)
        {
            throw new NotImplementedException();
        }
    }
}

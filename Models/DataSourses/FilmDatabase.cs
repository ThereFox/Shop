using System.Linq;
using System.ComponentModel;
using WebApplication1.Models.Abstraction;
using WebApplication1.Models.DataSourses.Types;

namespace WebApplication1.Models.DataSourses
{
    public class FilmDatabase : IFilmDataSourse, IAsyncDisposable
    {
        private FilmMsSQLDatabase _context;

        public FilmDatabase()
        {
            _context = new();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public Film? GetFilm(int id)
        {
            return _context.films.Where(film => film.Id == id).FirstOrDefault();
        }

        public List<Film> GetFilms(FilmFiltr filtrs, int count, int skipedElementCount)
        {
            List<Film> relevantFilms = _context.films
                .Where(film => film.Name.Contains(filtrs.Name))
                //.Where(film => film.Tags.Contains(filtrs.Tags))
                .ToList();
                ;
        }

        public List<Film> GetFilms(int count, int skipedElementCount)
        {
            throw new NotImplementedException();
        }
    }
}

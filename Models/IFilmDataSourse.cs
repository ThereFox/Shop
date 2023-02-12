using WebApplication1.Models.Types;

namespace WebApplication1.Models
{
    public interface IFilmDataSourse
    {
        public Film GetFilm(int id);
        public List<Film> GetFilms(int count, int page);
        public List<Film> GetFilms(FilmFiltr filtrs, int count, int page);
    }
}

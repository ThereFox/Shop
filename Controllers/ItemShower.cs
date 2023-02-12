using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("Item")]
    public class ItemShower : Controller
    {
        private readonly IFilmDataSourse filmDataSourse;
        public ItemShower(IFilmDataSourse dataSourse)
        {
            filmDataSourse= dataSourse;
        }

        [Route("{index}")]
        public IActionResult Index(int index)
        {
            Film film = filmDataSourse.GetFilm(index);
            return View(film);
        }
    }
}

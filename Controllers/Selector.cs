using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using WebApplication1.Models.Abstraction;
using WebApplication1.Models.DataSourses.Types;

namespace WebApplication1.Controllers
{
    [Route("Selector")]
    public class Selector : Controller
    {
        private readonly IFilmDataSourse _filmDataSource;

        public Selector(IFilmDataSourse filmSource)
        {
            _filmDataSource = filmSource;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var films = _filmDataSource.GetFilms(50, 0);
            return View(films);
        }

        [HttpPost]
        [Route("/{skippedElementCount}/{elementCount}")]
        public async ValueTask<IActionResult> GetFilms(HttpContext context, int skippedElementCount, int elementCount)
        {
            if (context.Request.HasJsonContentType())
            {
                return BadRequest();
            }

            FilmFiltr config = await context.Request.ReadFromJsonAsync<FilmFiltr>();

            List<Film> films = _filmDataSource.GetFilms(config, skippedElementCount, elementCount);

            return Json(films);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
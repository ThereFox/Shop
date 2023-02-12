using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("Selector")]
    public class Selector : Controller
    {
        private readonly ILogger<Selector> _logger;

        public Selector(ILogger<Selector> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
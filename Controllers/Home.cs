using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

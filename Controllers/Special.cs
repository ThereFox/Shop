using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Special : Controller
    {
        public IActionResult NotFoundPage()
        {
            return View("PageNotfound");
        }
    }
}

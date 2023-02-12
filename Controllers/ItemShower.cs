using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("Item")]
    public class ItemShower : Controller
    {
        [Route("{index}")]
        public IActionResult Index(int index)
        {
            return View(12);
        }
    }
}

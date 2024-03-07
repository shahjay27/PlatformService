using Microsoft.AspNetCore.Mvc;

namespace PlatformService.Controllers
{
    public class PlatformsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

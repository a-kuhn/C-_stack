using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class HomeRoutesController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
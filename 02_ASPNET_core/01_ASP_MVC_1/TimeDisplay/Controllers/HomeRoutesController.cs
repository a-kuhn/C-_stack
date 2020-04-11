using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDisplay.Controllers
{
    public class HomeRoutesController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            string hoursMinutes = CurrentTime.ToString("t");
            string date = CurrentTime.ToString("MMM d, yyyy");
            ViewBag.date = date;
            ViewBag.hoursMinutes = hoursMinutes;

            return View();
        }
    }
}
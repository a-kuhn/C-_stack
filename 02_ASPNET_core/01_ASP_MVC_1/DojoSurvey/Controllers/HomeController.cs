using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        //render form view
        [HttpGet("")]
        public IActionResult FormView()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string Name, string DojoLocation, string FavLang, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.DojoLocation = DojoLocation;
            ViewBag.FavLang = FavLang;
            ViewBag.Comment = Comment;

            return View();
        }

    }
}
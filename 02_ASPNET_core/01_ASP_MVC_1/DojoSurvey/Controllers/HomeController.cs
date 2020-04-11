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

        [HttpPost("formSubmit")]
        public IActionResult FormSubmit(string Name, string DojoLocation, string FavLang, string Comment)
        {
            string inputName = Name;
            string inputDojoLocation = DojoLocation;
            string inputFavLang = FavLang;
            string inputComment = Comment;

            return RedirectToAction("Result", new { Name = inputName, DojoLocation = inputDojoLocation, FavLang = inputFavLang, Comment = inputComment });
        }

        //handle form submit
        [HttpGet("result")]
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
using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

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

        // [HttpPost("result")]
        // public IActionResult Result(Survey survey)
        // {
        //     Survey newSurvey = new Survey(survey);
        //     return View(newSurvey);
        // }


        [HttpPost("result")]
        public IActionResult Result(Survey survey)
        {
            if (ModelState.IsValid)
            {
                Survey newSurvey = new Survey(survey);
                return View("Result", newSurvey);
                // redirect to success page
                // return RedirectToAction("Success");
            }
            else
            {
                // to display errors
                return View("FormView");
            }
        }

    }
}
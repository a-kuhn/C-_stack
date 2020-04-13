using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(User user)
        {
            if (ModelState.IsValid)
            {
                // redirect to success page
                return RedirectToAction("Success");
            }
            else
            {
                // to display errors
                return View("Index");
            }
        }

        [HttpGet("success")]
        public string Success()
        {
            return "Successfully Submitted!";
        }
    }
}

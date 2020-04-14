using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            //create count for # of passcode generations
            int count = 0;
            HttpContext.Session.SetInt32("Count", count + 1);
            int? codeCount = HttpContext.Session.GetInt32("Count");

            //generate a 14-char random passcode
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rand = new Random();
            string randPass = "";
            for (int i = 0; i < 14; i++)
            {
                randPass += chars[rand.Next(0, chars.Length)];
            }

            //add random passcode to session
            HttpContext.Session.SetString("RandomPasscode", randPass);
            string RandomPasscode = HttpContext.Session.GetString("RandomPasscode");

            //send session data to View
            ViewBag.Count = codeCount;
            ViewBag.RandomPasscode = randPass;

            return View();
        }

    }
}

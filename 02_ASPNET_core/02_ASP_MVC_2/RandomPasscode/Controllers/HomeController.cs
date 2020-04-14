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
            if (HttpContext.Session.GetInt32("Count") == null)
            {
                //create count for # of passcode generations
                HttpContext.Session.SetInt32("Count", 1);
            }

            int? count = HttpContext.Session.GetInt32("Count");
            Console.WriteLine($"\n******\nSession Count: {count}");

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
            ViewBag.Count = count;
            ViewBag.RandomPasscode = randPass;

            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            int newCount = (int)count;
            newCount++;
            HttpContext.Session.SetInt32("Count", newCount);
            Console.WriteLine($"\n@@@@@@@@\nSession newCount: {newCount}\n");

            return RedirectToAction("Index");
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
    }
}

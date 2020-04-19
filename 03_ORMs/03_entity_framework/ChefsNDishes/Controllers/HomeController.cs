using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private CDcontext db;
        public HomeController(CDcontext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            //load up all Chefs
            List<Chef> allChefs = db.Chefs
                .Include(c => c.ChefsDishes)
                .ToList();
            return View(allChefs);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateChef(Chef newChef)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewChef");
            }

            newChef.CreatedAt = DateTime.Now;
            newChef.UpdatedAt = DateTime.Now;
            db.Add(newChef);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}

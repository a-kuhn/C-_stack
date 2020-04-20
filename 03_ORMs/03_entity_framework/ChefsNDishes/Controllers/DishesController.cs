using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers
{
    public class DishesController : Controller
    {
        private CDcontext db;
        public DishesController(CDcontext context)
        {
            db = context;
        }


        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            //load up all Dishes (and their creators)
            List<Dish> allDishes = db.Dishes
                .Include(d => d.DishCreator)
                .ToList();

            return View(allDishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            //load up all Chefs for drop down menu on form
            ViewBag.allChefs = db.Chefs.ToList();
            return View();
        }

        [HttpPost("dishes/create")]
        public IActionResult CreateDish(Dish newDish)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewDish");
            }

            db.Add(newDish);
            db.SaveChanges();

            return RedirectToAction("Dishes");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CRUDContext dbContext;
        public HomeController(CRUDContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            //can add query to db 
            List<Dish> allDishes = dbContext.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .ToList();
            return View(allDishes);
        }

        [HttpGetAttribute("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Dish newDish)
        {
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("{DishId}")]
        public IActionResult Dish(int DishId)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == DishId);
            if (selectedDish == null) { return RedirectToAction(""); }
            return View(selectedDish);
        }

        [HttpGetAttribute("{DishId}/Edit")]
        public IActionResult Edit(int DishId)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == DishId);
            if (selectedDish == null) { return RedirectToAction(""); }
            return View(selectedDish);
        }

        [HttpPost("Update")]
        public IActionResult Update(Dish editedDish)
        {
            if (ModelState.IsValid == false)
            {
                // so error messages will be displayed and original input box values prefilled
                return View("Edit", editedDish);
            }
            // get old dish from db
            Dish dbDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == editedDish.DishId);
            // if dish doesn't exist (typing random #'s into url) return to home page
            if (dbDish == null)
            {
                return RedirectToAction("Index");
            }
            //update all dbDish fields with editedDish info
            dbDish.Name = editedDish.Name;
            dbDish.Chef = editedDish.Chef;
            dbDish.Calories = editedDish.Calories;
            dbDish.Tastiness = editedDish.Tastiness;
            dbDish.Description = editedDish.Name;
            dbDish.UpdatedAt = DateTime.Now;
            //save changes to db
            dbContext.Dishes.Update(dbDish);
            dbContext.SaveChanges();
            return RedirectToAction("Dish", new { DishId = dbDish.DishId });
        }

        [HttpGet("{DishId}/Delete")]
        public IActionResult Delete(int DishId)
        {
            dbContext.Dishes.Remove(dbContext.Dishes.FirstOrDefault(d => d.DishId == DishId));
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


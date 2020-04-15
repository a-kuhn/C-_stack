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

    }
}

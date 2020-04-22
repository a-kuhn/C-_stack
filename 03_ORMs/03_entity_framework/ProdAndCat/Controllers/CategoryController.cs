using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdAndCat.Models;

namespace ProdAndCat.Controllers
{
    public class CategoryController : Controller
    {
        private ProdCatContext db;
        public CategoryController(ProdCatContext context)
        {
            db = context;
        }

        [HttpGet("")] //render category page
        public IActionResult Category(int id)
        {
            //load up all categories
            ViewBag.AllCategories = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(p => p.Category)
                .ToList();

            ViewBag.Category = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(p => p.Category)
                .FirstOrDefault(c => c.CategoryId == id);

            return View();
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(prod => prod.Product)
                .ToList();
            return View();
        }

        [HttpPost("categories/create")] //create new product
        public IActionResult Create(Category newCategory)
        {
            //add new prod to db
            {
                if (ModelState.IsValid == false)
                {
                    return View("Categories");
                }
                db.Add(newCategory);
                db.SaveChanges();
                return RedirectToAction("Categories");
            }
        }

        [HttpPost("categories/createAssociation")] //create new Association
        public IActionResult CreateAssociation(Product newProduct)
        {
            //create new association between cat.CategoryId and prod.ProductId
            //change redirect to go back to category with newly-added product displayed

            

            return RedirectToAction("Categories");
        }
    }
}
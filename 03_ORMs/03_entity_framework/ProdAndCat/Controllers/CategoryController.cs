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
        public IActionResult Category(int CategoryId)
        {
            //load up all categories
            ViewBag.AllCategories = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(a => a.Product)
                .ToList();

            ViewBag.Category = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(c => c.CategoryId == CategoryId);

            ViewBag.AllProducts = db.Products
                .Include(p => p.CategoriesOfProduct)
                .ThenInclude(a => a.Product)
                .ToList();

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
        public IActionResult CreateAssociation(Association newAssociation)
        {
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("Category", new { CategoryId = newAssociation.CategoryId });
        }
    }
}
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
    public class ProductController : Controller
    {
        private ProdCatContext db;
        public ProductController(ProdCatContext context)
        {
            db = context;
        }

        [HttpGet("products")] //render all products view
        public IActionResult Products()
        {
            ViewBag.AllProducts = db.Products
                .Include(p => p.CategoriesOfProduct)
                .ThenInclude(cat => cat.Category)
                .ToList();

            return View();
        }

        [HttpGet("products/{ProductId}")] //render single product
        public IActionResult Product(int ProductId)
        {
            // List<Category> AllCategories = db.Categories
            //     .Include(c => c.ProductsInCategory)
            //     .ThenInclude(a => a.Product)
            //     .ToList();
            // ViewBag.AllCategories = AllCategories;

            List<Category> unassociatedProducts = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(p => p.Product)
                .ToList();
            ViewBag.unassociatedProducts = unassociatedProducts;

            Product selectedProd = db.Products
                .FirstOrDefault(p => p.ProductId == ProductId);
            ViewBag.selectedProd = selectedProd;

            return View();
        }

        [HttpPost("products/create")] //create new product
        public IActionResult Create(Product newProduct)
        {
            //add new prod to db
            {
                if (ModelState.IsValid == false)
                {
                    return View("Products");
                }
                db.Add(newProduct);
                db.SaveChanges();
                return RedirectToAction("Products");
            }
        }

        [HttpPost("products/createAssociation")] //create new Association
        public IActionResult CreateAssociation(Association newAssociation)
        {
            //create new association between prod.ProductId and cat.CategoryId
            //change redirect to go back to product with newly-added category displayed

            Console.WriteLine($"newAssociation: {newAssociation}");
            Console.WriteLine($"last stop before attempting to create new association in db");

            db.Add(newAssociation);
            db.SaveChanges();

            return RedirectToAction("Product", new {newAssociation.ProductId});
        }
    }
}

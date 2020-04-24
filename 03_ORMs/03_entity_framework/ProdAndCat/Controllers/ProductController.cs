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
            ViewBag.AllCategories = db.Categories
                .Include(c => c.ProductsInCategory)
                .ThenInclude(a => a.Product)
                .ToList();

            ViewBag.Product = db.Products
                .Include(p => p.CategoriesOfProduct)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == ProductId);

            ViewBag.AllProducts = db.Products
                .Include(p => p.CategoriesOfProduct)
                .ThenInclude(a => a.Product)
                .ToList();

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
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("Product", new { ProductId = newAssociation.ProductId });
        }

    }
}

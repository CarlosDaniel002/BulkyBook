﻿using BulkyBook.Web.Data;
using BulkyBook.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategories = _db.Categories;
            return View(objCategories);
        }
    }
}

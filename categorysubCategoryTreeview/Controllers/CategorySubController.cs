using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using categorysubCategoryTreeview.Models;

namespace categorysubCategoryTreeview.Controllers
{
    public class CategorySubController : Controller
    {

        private readonly CatDbContext _context;
        private readonly bindSubcategory _bindSubcategory;
        public CategorySubController(CatDbContext context, bindSubcategory bindSubcategory)
        {
            _context = context;
            _bindSubcategory = bindSubcategory;
        }

        public IActionResult Index()
        {
            var Categories = _context.Categories.Where(c => c.ParentCategory == null)
                .Select(c => new CategoryViewModel()
                {
                    CategoryId = c.CatId,
                    CategoryName = c.CategoryName
                }).ToList();
            foreach (var Item in Categories)
            {
                _bindSubcategory.bind(Item);
            }
           
            return View(Categories);
        }
    }
}

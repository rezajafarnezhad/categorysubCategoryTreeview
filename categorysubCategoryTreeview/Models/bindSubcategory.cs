using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace categorysubCategoryTreeview.Models
{
    public class bindSubcategory
    {

        private readonly CatDbContext _context;

        public bindSubcategory(CatDbContext context)
        {
            _context = context;
        }

        public void bind(CategoryViewModel category)
        {
            var subcategory =
                _context.Categories.Where(c => c.ParentCategory == category.CategoryId)
                    .Select(c => new CategoryViewModel()
                    {
                        CategoryId = c.CatId,
                        CategoryName = c.CategoryName
                    }).ToList();

            foreach (var item in subcategory)
            {
                bind(item);
                category.Categories.Add(item);
            }

        }


    }
}

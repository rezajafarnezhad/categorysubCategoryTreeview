using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace categorysubCategoryTreeview.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<CategoryViewModel> Categories { get; set; }

        public CategoryViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }


    }
}

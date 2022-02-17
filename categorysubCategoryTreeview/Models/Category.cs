using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace categorysubCategoryTreeview.Models
{
    public class Category
    {
        public int CatId { get; set; }
        public string CategoryName { get; set; }

        public int? ParentCategory { get; set; }


        public Category category { get; set; }

        public List<Category> Categories { get; set; }

    }
}

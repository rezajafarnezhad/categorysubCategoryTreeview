using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace categorysubCategoryTreeview.Models
{
    public class CatDbContext:DbContext
    {

        public CatDbContext(DbContextOptions<CatDbContext> options):base(options)
        {
            
        }


        public DbSet<Category> Categories { get; set; }

        #region Overrides of DbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.CatId);
            modelBuilder.Entity<Category>()
                .HasOne(c => c.category)
                .WithMany(c => c.Categories)
                .HasForeignKey(c => c.ParentCategory);
        }

        #endregion
    }
}

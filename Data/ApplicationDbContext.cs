using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vscode_spice.Models;

namespace vscode_spice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        // dotnet ef migrations add addCategoryToDatabase

        public DbSet<SubCategory> SubCategory { get; set; }
        // dotnet ef migrations add addSubCategoryToDatabase

        public DbSet<MenuItem> MenuItem { get; set; }
        // dotnet ef migrations add addMenuItemToDatabase
        // WARNING
        // Gives error when using SQL Server but not on SLQ Lite
        // Change onDelete: ReferentialAction.NoAction);
        // before database update

        public DbSet<Coupon> Coupon { get; set; }
        // dotnet ef migrations add addCouponToDatabase

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        // dotnet ef migrations add addMoreFieldsToIdentityUser

        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        // dotnet ef migrations add addShoppingCartToDatabase
        // dotnet ef database update
    }
}

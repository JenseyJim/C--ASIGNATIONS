

using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Entities;

namespace ShopApp.DAL.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions <ShopContext> options) : base(options)
        {
                  
        }
        public DbSet <Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

    }
}

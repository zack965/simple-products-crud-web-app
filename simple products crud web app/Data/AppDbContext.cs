using Microsoft.EntityFrameworkCore;
using simple_products_crud_web_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_products_crud_web_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<AuthorDependency> authors { get; set; }
    }
}

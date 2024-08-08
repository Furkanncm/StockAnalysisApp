using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository
{
    public class StockAnalyzeAppContext:DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Stock> Stock { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Company> Companies { get; set; }

        public StockAnalyzeAppContext(DbContextOptions<StockAnalyzeAppContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

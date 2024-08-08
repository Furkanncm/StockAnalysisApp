using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.SeedData
{
    public class OrderData : IEntityTypeConfiguration<Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                 new Order { Id = 1, OrderCode = 5001, Quantity = 10, Price = 1000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 1 },
            new Order { Id = 2, OrderCode = 5002, Quantity = 20, Price = 2000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 1 },
            new Order { Id = 3, OrderCode = 5003, Quantity = 30, Price = 3000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 2 },
            new Order { Id = 4, OrderCode = 5004, Quantity = 40, Price = 4000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 2 },
            new Order { Id = 5, OrderCode = 5005, Quantity = 50, Price = 5000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 3 },
            new Order { Id = 6, OrderCode = 5006, Quantity = 60, Price = 6000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 3 },
            new Order { Id = 7, OrderCode = 5007, Quantity = 70, Price = 7000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 4 },
            new Order { Id = 8, OrderCode = 5008, Quantity = 80, Price = 8000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 4 },
            new Order { Id = 9, OrderCode = 5009, Quantity = 90, Price = 9000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 5 },
            new Order { Id = 10, OrderCode = 5010, Quantity = 100, Price = 10000m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 5 }
            );
            
        }
    }
}

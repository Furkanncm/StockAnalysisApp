using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.SeedData
{
    public class StockData : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasData(
                new Stock { Id = 1, Name = "AAPL", Type = "Technology", StockCode = 10001, Quantity = 50, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 1 },
            new Stock { Id = 2, Name = "GOOGL", Type = "Technology", StockCode = 10002, Quantity = 30, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 1 },
            new Stock { Id = 3, Name = "MSFT", Type = "Technology", StockCode = 10003, Quantity = 20, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 2 },
            new Stock { Id = 4, Name = "AMZN", Type = "Retail", StockCode = 10004, Quantity = 40, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 2 },
            new Stock { Id = 5, Name = "TSLA", Type = "Automotive", StockCode = 10005, Quantity = 60, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 3 },
            new Stock { Id = 6, Name = "FB", Type = "Social Media", StockCode = 10006, Quantity = 70, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 3 },
            new Stock { Id = 7, Name = "NFLX", Type = "Entertainment", StockCode = 10007, Quantity = 80, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 4 },
            new Stock { Id = 8, Name = "NVDA", Type = "Technology", StockCode = 10008, Quantity = 90, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 4 },
            new Stock { Id = 9, Name = "AMD", Type = "Technology", StockCode = 10009, Quantity = 100, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 5 },
            new Stock { Id = 10, Name = "INTC", Type = "Technology", StockCode = 10010, Quantity = 110, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, UserId = 5 }
                );
        }
    }
}

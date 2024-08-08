using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.HasIndex(x => x.OrderCode).IsUnique();
            builder.Property(x => x.OrderCode).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasPrecision(18,2);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
            builder.Property(x=>x.TotalPrice).HasComputedColumnSql("[Quantity]*[Price]").HasPrecision(18,2);
           
        }
    }
}

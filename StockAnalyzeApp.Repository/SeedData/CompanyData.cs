using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.SeedData
{
    public class CompanyData : IEntityTypeConfiguration<Company>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                 new Company { Id = 1, Name = "TechCorp", Address = "123 Tech Street", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 2, Name = "Innovate Inc.", Address = "456 Innovation Ave", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 3, Name = "Alpha Co.", Address = "789 Alpha Road", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 4, Name = "Beta Corp.", Address = "321 Beta Blvd", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 5, Name = "Gamma LLC", Address = "654 Gamma Lane", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 6, Name = "Delta Ltd.", Address = "987 Delta Drive", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 7, Name = "Epsilon Enterprises", Address = "147 Epsilon Parkway", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 8, Name = "Zeta Solutions", Address = "258 Zeta Avenue", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 9, Name = "Eta Inc.", Address = "369 Eta Street", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Company { Id = 10, Name = "Theta Technologies", Address = "741 Theta Way", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}

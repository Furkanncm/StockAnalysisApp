using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.SeedData
{
    public class UserData : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User { Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", Password = "password1", UserCode = 1001, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 1 },
            new User { Id = 2, FirstName = "Jane", LastName = "Doe", Address = "456 Oak St", Password = "password2", UserCode = 1002, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 2 },
            new User { Id = 3, FirstName = "Jim", LastName = "Beam", Address = "789 Pine St", Password = "password3", UserCode = 1003, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 3 },
            new User { Id = 4, FirstName = "Jack", LastName = "Daniels", Address = "321 Maple St", Password = "password4", UserCode = 1004, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 4 },
            new User { Id = 5, FirstName = "Johnny", LastName = "Walker", Address = "654 Elm St", Password = "password5", UserCode = 1005, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 5 },
            new User { Id = 6, FirstName = "Tom", LastName = "Collins", Address = "987 Cedar St", Password = "password6", UserCode = 1006, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 5 },
            new User { Id = 7, FirstName = "Margarita", LastName = "Garcia", Address = "147 Birch St", Password = "password7", UserCode = 1007, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 6 },
            new User { Id = 8, FirstName = "Mojito", LastName = "Smith", Address = "258 Cherry St", Password = "password8", UserCode = 1008, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 6},
            new User { Id = 9, FirstName = "Mai", LastName = "Tai", Address = "369 Walnut St", Password = "password9", UserCode = 1009, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 7 },
            new User { Id = 10, FirstName = "Piña", LastName = "Colada", Address = "741 Ash St", Password = "password10", UserCode = 1010, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, CompanyId = 7 }
            );
        }
    }
}

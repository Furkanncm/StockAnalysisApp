using StockAnalyzeApp.Core.Dto.UserDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.CompanyDtos
{
    public class CompanywithUsers:CompanyAddDto
    {
        public ICollection<UserResponseDto> Users { get; set; }
    }
}

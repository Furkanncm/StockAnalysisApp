using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto
{
    public class UserWithOrdersDto:UserResponseDto
    {
        public List<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderAddDto
    {
        public string OrderCode { get; set; } 

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int UserId { get; set; }
    }
}

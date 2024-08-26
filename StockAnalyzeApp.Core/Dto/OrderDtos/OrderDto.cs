using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderDto : BaseOrderDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; } // Eklenen özellik
    }
}

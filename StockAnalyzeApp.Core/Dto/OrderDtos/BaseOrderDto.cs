using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class BaseOrderDto
    {
        public string OrderCode { get; set; }
        public int Quantity { get; set; } = 0;
        public DateTime CreatedDate { get; set; } // Otomatik atama
        public DateTime UpdatedDate { get; set; } // Otomatik atama
    }

}

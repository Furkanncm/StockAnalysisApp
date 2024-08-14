using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderWithOrderCodeDto
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }

        public int Quantity { get; set; }

    }
}

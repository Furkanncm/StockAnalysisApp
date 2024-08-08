using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderUpdateDto:OrderAddDto
    {
        public int Id { get; set; }
    }
}

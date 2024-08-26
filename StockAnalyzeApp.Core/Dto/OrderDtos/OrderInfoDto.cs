using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderInfoDto:BaseOrderDto
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }


    }
}

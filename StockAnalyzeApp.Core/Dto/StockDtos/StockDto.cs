using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.StockDtos
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public string StockCode { get; set; }

        public int Quantity { get; set; }

        public int UserId { get; set; }

        public string OrderCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.StockDtos
{
    public class AddStockWithAcceptOrder
    {
        public string Name { get; set; }
        public string Type { get; set; }

        [JsonIgnore]
        public int Quantity { get; set; }
        public string OrderCode { get; set; }
        public string StockCode
        {
            get => $"{OrderCode}{Quantity}";
        }
    }
}

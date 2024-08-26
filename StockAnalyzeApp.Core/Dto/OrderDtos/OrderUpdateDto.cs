using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderUpdateDto
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; }

        [JsonIgnore]
        public DateTime UpdatedDate { get; set; }

    }
}

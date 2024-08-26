using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.StockDtos
{
    public class StockUpdateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        [JsonIgnore]
        public string? OrderCode { get; set; }
        [JsonIgnore]
        public string? StockCode { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; }

        [JsonIgnore]
        public DateTime UpdatedDate { get; set; }= DateTime.Now;
    }
}

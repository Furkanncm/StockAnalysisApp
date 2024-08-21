using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.CompanyDtos
{
    public class CompanyUpdateDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; }

        [JsonIgnore]
        public DateTime UpdatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockAnalyzeApp.Core.Dto.StockDtos;

namespace StockAnalyzeApp.Core.Dto.UserDtos
{
    public class UserWithStocksDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int UserCode { get; set; }

        public IEnumerable<StockDto> Stocks { get; set; } = new List<StockDto>();
    }
}

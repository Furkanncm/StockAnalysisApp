using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Models
{
    public class Order:BaseModel
    {
        public int OrderCode { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

    }
}

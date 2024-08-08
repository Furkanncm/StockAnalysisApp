using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Models
{
    public class User:BaseModel
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int UserCode { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}

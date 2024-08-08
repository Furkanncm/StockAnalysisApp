using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Models
{
    public class Company:BaseModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

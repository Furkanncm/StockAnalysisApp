using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Models
{
    public class OrderAcceptance
    {
        public int Id { get; set; }

        public int OrderCode { get; set; }

        public DateTime AcceptedDate { get; set; }

        public string Status { get; set; }

        public int OrderId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Models
{
    public class NotificationRequest
    {
        public string Token { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}

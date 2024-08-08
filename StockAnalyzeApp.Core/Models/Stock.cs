﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Models
{
    public class Stock:BaseModel
    { 
        public string Name { get; set; }

        public string Type { get; set; }

        public int StockCode { get; set; }

        public int Quantity { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}

﻿using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.OrderDtos
{
    public class OrderWithUserDto : OrderDto
    {
        public User User { get; set; } // UserDto ile ilişkili
    }

}

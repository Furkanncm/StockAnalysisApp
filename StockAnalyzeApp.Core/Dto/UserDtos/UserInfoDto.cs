using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.UserDtos
{
    public class UserInfoDto : UserResponseDto
    {
        public Company Company { get; set; }

    }
}

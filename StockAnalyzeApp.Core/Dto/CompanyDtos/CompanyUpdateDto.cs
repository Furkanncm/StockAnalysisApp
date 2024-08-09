using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.CompanyDtos
{
    public class CompanyUpdateDto:CompanyAddDto
    {
        public int Id { get; set; }
    }
}

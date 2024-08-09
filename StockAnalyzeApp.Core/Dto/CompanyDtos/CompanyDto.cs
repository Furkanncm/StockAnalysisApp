using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto.CompanyDtos
{
    public class CompanyDto:CompanyAddDto
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

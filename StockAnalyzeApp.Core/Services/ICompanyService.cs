using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface ICompanyService:IService<Company>
    {
        Task<CustomResponseDto<CompanywithUsers>> GetCompanyUsers(int companyId);

        Task<List<int>> GetCompanyIds();
    }

}

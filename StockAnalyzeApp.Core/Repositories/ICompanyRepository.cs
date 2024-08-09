using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Repositories
{
    public interface ICompanyRepository:IGenericRepository<Company>
    {
        Task<Company> GetCompanyUsers(int companyId);

        List<int> GetCompanyIds();
    }
}

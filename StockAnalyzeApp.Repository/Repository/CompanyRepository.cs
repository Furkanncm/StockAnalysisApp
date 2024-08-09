using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.Repository
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {

        public CompanyRepository(StockAnalyzeAppContext context) : base(context)
        {
        }

        public List<int> GetCompanyIds()
        {
            return _context.Companies.Select(x=>x.Id).ToList();
        }

        public async Task<Company> GetCompanyUsers(int companyId)
        {
           return  await _context.Companies.Include(x => x.Users).FirstOrDefaultAsync(x => x.Id == companyId);
        }
    }
}

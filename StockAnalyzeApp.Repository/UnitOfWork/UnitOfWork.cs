using StockAnalyzeApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StockAnalyzeAppContext _context;

        public UnitOfWork(StockAnalyzeAppContext context)
        {
            _context=context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

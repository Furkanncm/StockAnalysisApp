using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;

namespace StockAnalyzeApp.Repository.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(StockAnalyzeAppContext context) : base(context)
        {
        }

        public async Task<User> GetUserByUserCode(int userCode)
        {
            var response=await _context.Users.FirstOrDefaultAsync(x => x.UserCode == userCode);
            return response;

        }

        public async Task<User> GetUsersOrders(int userId)
        {
            var response = await _context.Users.Include(x => x.Orders).FirstOrDefaultAsync(x => x.Id == userId);
            return response;
        }
    }
}

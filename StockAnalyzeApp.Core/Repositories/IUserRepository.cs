using StockAnalyzeApp.Core.Dto;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Repositories
{
    public interface IUserRepository: IGenericRepository<User>
    {

        Task<User> GetUserByUserCode(int userCode);

        Task<User> GetUsersOrders(int userId);

        Task<User> GetUsersStocks(int userId);
    }
}

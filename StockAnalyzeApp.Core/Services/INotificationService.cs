using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface INotificationService
    {
        Task SendNotification(int userId, string message);
    }

}

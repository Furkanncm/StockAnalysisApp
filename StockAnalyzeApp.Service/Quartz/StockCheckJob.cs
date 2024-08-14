using Microsoft.Extensions.DependencyInjection;
using Quartz;
using StockAnalyzeApp.Core.Services;
using System;
using System.Threading.Tasks;

public class StockCheckJob : IJob
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public StockCheckJob(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var stockService = scope.ServiceProvider.GetRequiredService<IStockService>();
            var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

            // Stock miktarlarını kontrol etme işlemi
            var noStockItems = await stockService.GetDontHaveStocks();
            foreach (var stock in noStockItems.Data)
            {
                // Bildirim gönderme işlemini gerçekleştirin.
                await notificationService.SendNotification(stock.UserId, $"StockCode: {stock.StockCode} miktarı sıfır. Bildirim gönderildi.");
            }
        }
    }
}

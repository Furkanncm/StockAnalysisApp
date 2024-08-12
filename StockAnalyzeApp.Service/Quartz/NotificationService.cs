
using StockAnalyzeApp.Core.Services;

public class NotificationService : INotificationService
{
    public Task SendNotification(int userId, string message)
    {
        // Burada bildirim gönderme işlemi yapılır.
        Console.WriteLine($"User: {userId}, Message: {message}");
        return Task.CompletedTask;
    }
}


using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Repository.Repository;

public class NotificationService : INotificationService
{
    private readonly IUserRepository userRepository;

    public NotificationService(IUserRepository userRepository)
    {
        this.userRepository=userRepository;
    }

    public async Task SendNotification(int userId, string message)
    {
        // Burada bildirim gönderme işlemi yapılır.
        Console.WriteLine($"User: {userId}, Message: {message}");
        var user = await userRepository.GetByIdAsync(userId);
        if (user.DeviceToken != null)
        {
            var firebaseService = new FirebaseService();
            await firebaseService.SendNotificationAsync(
               user.DeviceToken,
               "Stoklar Kontrol edildi",
               "Kontrol işlemi tamamlandı."
           );
        }

    }
}

using Google.Apis.Auth.OAuth2;
using Google.Apis.FirebaseCloudMessaging.v1;
using Google.Apis.FirebaseCloudMessaging.v1.Data;
using Google.Apis.Services;
using System.Threading.Tasks;

public class FirebaseService
{
    private readonly FirebaseCloudMessagingService _fcmService;

    public FirebaseService()
    {
        // Service Account JSON dosyasını yükle
        var credential = GoogleCredential.FromFile("C:\\Users\\furka\\source\\repos\\StockAnalyzeApp\\StockAnalyzeApp.Service\\test-578bb-firebase-adminsdk-jsbm1-871ef92dcc.json")
            .CreateScoped("https://www.googleapis.com/auth/firebase.messaging");

        _fcmService = new FirebaseCloudMessagingService(new BaseClientService.Initializer
        {
            HttpClientInitializer = credential
        });
    }

    public async Task SendNotificationAsync(string token, string title, string body)
    {
        var message = new Message
        {
            Token = token,
            Notification = new Notification
            {
                Title = title,
                Body = body
            }
        };

        var request = new SendMessageRequest
        {
            Message = message
        };

       var response= await _fcmService.Projects.Messages.Send(request, "projects/test-578bb").ExecuteAsync();
        Console.WriteLine(response);
    }
}

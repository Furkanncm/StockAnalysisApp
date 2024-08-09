using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class FirebaseService
{
    private readonly string _serverKey = "BCD5pC2T0EihvqeuFqBYPI3h5NcJilZUGB9Sy_KUca1EFOmuv9vtyVlZ322vPabu5t0p3b37dZ_1c07ZZp8ICu4";
    private readonly string _senderId = "999372835651";
    private readonly string _fcmUrl = "https://fcm.googleapis.com/fcm/send";

    public async Task SendNotificationAsync(string title, string body, string deviceToken)
    {
        using (var httpClient = new HttpClient())
        {
            var messageInformation = new
            {
                notification = new
                {
                    title = title,
                    body = body
                },
                to = deviceToken // Tek bir cihaza mesaj göndermek için kullanılır
                // Eğer birden fazla cihaza göndermek istiyorsanız `registration_ids` kullanabilirsiniz.
            };

            var jsonMessage = JsonConvert.SerializeObject(messageInformation);

            var request = new HttpRequestMessage(HttpMethod.Post, _fcmUrl);
            request.Headers.TryAddWithoutValidation("Authorization", $"key={_serverKey}");
            request.Headers.TryAddWithoutValidation("Sender", $"id={_senderId}");
            request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }
    }
}

//using Microsoft.AspNetCore.Mvc;

//[ApiController]
//[Route("api/[controller]")]
//public class NotificationController : ControllerBase
//{
//    private readonly FirebaseService _firebaseService;

//    public NotificationController(FirebaseService firebaseService)
//    {
//        _firebaseService = firebaseService;
//    }

//    [HttpPost("send")]
//    public async Task<IActionResult> SendNotification([FromBody] NotificationRequest request)
//    {
//        await _firebaseService.SendNotificationAsync(request.Title, request.Body, request.DeviceToken);
//        return Ok("Notification sent successfully");
//    }
//}

//public class NotificationRequest
//{
//    public string Title { get; set; }
//    public string Body { get; set; }
//    public string DeviceToken { get; set; }
//}

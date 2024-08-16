using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Models;

[ApiController]
[Route("api/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly FirebaseService _firebaseService;

    public NotificationController(FirebaseService firebaseService)
    {
        _firebaseService = firebaseService;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendNotification([FromBody]  NotificationRequest request)
    {
        await _firebaseService.SendNotificationAsync(request.Token, request.Title, request.Body);
        return Ok("Notification sent");
    }
}



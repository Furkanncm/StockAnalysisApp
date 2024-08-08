using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Services;

namespace StockAnalyzeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper=mapper;
            _userService=userService;
        }

        [HttpGet("[action]/{UserCode}")]
        public async Task<IActionResult> GetUserByUserCode(int UserCode)
        {
            var result = await _userService.GetUserByUserCode(UserCode);
            return Ok(result);
        }

        [HttpGet("[action]/{UserId}")]
        public async Task<IActionResult> GetUsersOrders(int UserId)
        {
            var result = await _userService.GetUsersOrders(UserId);
            return Ok(result);
        }
    }
}

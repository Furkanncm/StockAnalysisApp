using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.UserDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Services;

namespace StockAnalyzeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly ICompanyService companyService;

        public UserController(IMapper mapper, IUserService userService, ICompanyService companyService)
        {
            _mapper=mapper;
            _userService=userService;
            this.companyService=companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _userService.GetAllAsync();
            var responsedto = _mapper.Map<IEnumerable<UserResponseDto>>(result);
            return Ok(CustomResponseDto<IEnumerable<UserResponseDto>>.Success(responsedto, 200));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _userService.GetByIdAsync(id);
            var responsedto = _mapper.Map<UserResponseDto>(result);
            return Ok(CustomResponseDto<UserResponseDto>.Success(responsedto, 200));
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

        [HttpGet("[action]/{UserId}")]
        public async Task<IActionResult> GetUsersStocks(int UserId)
        {
            var result = await _userService.GetUsersStocks(UserId);
            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> AddUsers(UserAddDto userAddDto)
        {
            var entity = _mapper.Map<User>(userAddDto);
            var list=await companyService.GetCompanyIds();
            if (!list.Contains(userAddDto.CompanyId))
            {
                return Ok(CustomResponseDto<NoContentDto>.Fail("CompanyId is not Valid", 400));
            }
            else
            {
                await _userService.AddAsync(entity);
                return Created();
            }
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateUsers(UserUpdateDto userUpdateDto)
        {
            var dto = _mapper.Map<User>(userUpdateDto);
            var entity =  _userService.Update(dto);
            return Ok(CustomResponseDto<UserUpdateDto>.Success(userUpdateDto, 200));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers(int id)
        {
            var entity = await _userService.GetByIdAsync(id);
            await _userService.Delete(id);
            return Ok(CustomResponseDto<NoContentDto>.Success( 200));
        }
    }
}

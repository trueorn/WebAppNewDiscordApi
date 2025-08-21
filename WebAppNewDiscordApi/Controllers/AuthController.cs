using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebAppNewDiscordApi.DataMappers;
using WebAppNewDiscordApi.DataTransferObjects;
using WebAppNewDiscordApi.Entities;
using WebAppNewDiscordApi.Services;

namespace WebAppNewDiscordApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("GetUserByEmail")]
        public async Task<IActionResult> GetUserByEmail([FromBody] UserLoginEmailDto login)
        {
            if (string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Password))
            {
                return BadRequest("User data is required");
            }

            User user = await _userService.GetUserAsync(login.Email, login.Password);
            if (user == null)
            {
                return NotFound($"User {login.Email} Not Found");
            }

            return Ok(UserResponseMapper.MapToDto(user));
        }

        [HttpPost("GetUserByPhone")]
        public async Task<IActionResult> GetUserByPhone([FromBody] UserLoginPhoneDto login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = await _userService.GetUserAsync(login.Phone, login.Password);
            if (user == null)
            {
                return NotFound($"User {login.Phone} Not Found");
            }

            // нужно убрать из ответа секретные поля + ненужные
            return Ok(UserResponseMapper.MapToDto(user));
        }

        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserDto newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            //newUser.Password = Hash("sha256", newUser.Password);

            User user = await _userService.RegisterNewUserAsync(
                newUser.Fio, 
                newUser.Email, 
                newUser.Login, 
                newUser.Phone, 
                newUser.Password,
                newUser.IsEmailConfirmed
            );
            return Ok(UserResponseMapper.MapToDto(user));
        }
    }
}

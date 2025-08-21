using WebAppNewDiscordApi.DataTransferResponseObjects;
using WebAppNewDiscordApi.Entities;

namespace WebAppNewDiscordApi.DataMappers
{
    public class UserResponseMapper
    {
        public static UserResponseDto MapToDto(User user)
        {
            return new UserResponseDto
            {
                Id = user.Id,
                Fio = user.Fio,
                Email = user.Email,
                Phone = user.Phone,
               
            };
        }
    }
}

using WebAppNewDiscordApi.Entities;

namespace WebAppNewDiscordApi.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(string email, string password);
        Task<User> RegisterNewUserAsync(string fio, string? email, string login, string? phone, string password, bool isEmailConfirmed);
    }
}

using System.Text.Json;
using WebAppNewDiscordApi.Entities;

namespace WebAppNewDiscordApi.Services
{
    public class UserService: IUserService
    {
        public async Task<User> GetUserAsync(string email, string password)
        {
            // используем EF
            // в коллекйции users находим пользователя и возвращаем его

            var findedUser = new User()
            {
                Id = 1,
                Email = "admin@admin.com",
                Password = "7754f75c2f5854a0ae1de8e3d5f418d64d3d34a8fe91321f4298428138b13ab2",      // qwertY13 
                CreatedAt = DateTime.Now,
                Fio = "Администратор Фдминистрат Администратович",
                Login = "Adminer",
                Phone = "+380999999999"
            };

            return findedUser;
        }

        public Task<User> RegisterNewUserAsync(string fio, string? email, string login, string? phone, string password, bool isEmailConfirmed)
        {
            throw new NotImplementedException();
        }
    }
}

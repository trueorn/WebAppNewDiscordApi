using System.ComponentModel.DataAnnotations;

namespace WebAppNewDiscordApi.DataTransferObjects
{
    public class UserLoginEmailDto
    {

        [EmailAddress(ErrorMessage = "Некорректный формат Email")]
        public string Email { get; set; } = String.Empty;


        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль должен быть от 6 до 100 символов")]
        public string Password { get; set; } = string.Empty;
    }
}

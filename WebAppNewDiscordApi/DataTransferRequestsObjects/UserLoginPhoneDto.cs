using System.ComponentModel.DataAnnotations;

namespace WebAppNewDiscordApi.DataTransferObjects
{
    public class UserLoginPhoneDto
    {

        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string Phone { get; set; } = String.Empty;


        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль должен быть от 6 до 100 символов")]
        public string Password { get; set; } = string.Empty;
    }
}

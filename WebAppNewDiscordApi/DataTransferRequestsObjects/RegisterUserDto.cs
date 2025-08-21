using System.ComponentModel.DataAnnotations;

namespace WebAppNewDiscordApi.DataTransferObjects
{
    public class RegisterUserDto
    {
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string? Phone { get; set; }

        [EmailAddress(ErrorMessage = "Некорректный формат Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Логин обязателен")]
        [StringLength(16, ErrorMessage = "Логин не может превышать 50 символов")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "ФИО обязательно")]
        [StringLength(128, ErrorMessage = "ФИО не может быть длиннее 128 символов")]
        public string Fio { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль должен быть от 6 до 100 символов")]
        public string Password { get; set; } = string.Empty;

        public bool IsEmailConfirmed { get; set; }
    }
}

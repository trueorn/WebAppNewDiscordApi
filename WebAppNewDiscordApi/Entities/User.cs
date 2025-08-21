using System.ComponentModel.DataAnnotations;

namespace WebAppNewDiscordApi.Entities
{
    public class User
    {
        [Key] // первичный ключ
        public int Id { get; set; }

        [Required(ErrorMessage = "ФИО обязательно")]
        [StringLength(128, ErrorMessage = "ФИО не может быть длиннее 128 символов")]
        public string Fio { get; set; } = string.Empty;


        [Required(ErrorMessage = "Login обязательно")]
        [StringLength(16, ErrorMessage = "ФИО не может быть длиннее 16 символов")]
        public string Login { get; set; } = String.Empty;

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный формат email")]
        [StringLength(64, ErrorMessage = "Email не может быть длиннее 64 символов")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(256, ErrorMessage = "Пароль не может быть длиннее 256 символов")]
        public string Password { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Phone(ErrorMessage = "Некорректный номер телефона")]
        [StringLength(20, ErrorMessage = "Телефон не может быть длиннее 20 символов")]
        public string Phone { get; set; } = string.Empty;


        public bool IsEmailConfirmed { get; set; } = false;
    }
}

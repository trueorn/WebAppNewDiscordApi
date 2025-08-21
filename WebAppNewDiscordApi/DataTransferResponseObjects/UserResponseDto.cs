namespace WebAppNewDiscordApi.DataTransferResponseObjects
{
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Fio { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool IsEmailConfirmed { get; set; } = false;
    }
}

namespace hackweek_backend.dtos
{
    public class UserDtoUpdate
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
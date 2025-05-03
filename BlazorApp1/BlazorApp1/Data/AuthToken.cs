namespace BlazorApp1.Data
{
    public class AuthToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; } = string.Empty;

        public User? User { get; set; }
    }
}

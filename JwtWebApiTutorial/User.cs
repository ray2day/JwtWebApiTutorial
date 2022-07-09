namespace JwtWebApiTutorial
{
    public class User
    {
        //public int Id { get; set; } -> wanneer je database gerbuikt
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

namespace SocialNetwork.Core.Application.Dtos.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsVerified { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}

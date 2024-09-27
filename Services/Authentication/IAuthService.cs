using AuthApp.Dtos;

namespace AuthApp.Services.Authentication
{
    public interface IAuthService
    {
        Task<string>RegisterAsync(RegisterDto request);
        Task<string>LoginAsync(LoginDto request);
    }
}

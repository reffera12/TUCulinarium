using Microsoft.AspNetCore.Identity;
using TUKulinarium_API.Data.DTOs;

public interface IAuthRepository
{
    public Task<SignInResult> LoginAsync(string Email, string Password, bool rememberMe);
    public Task<IdentityResult> RegisterAsync(RegisterDTO registerDTO);
}
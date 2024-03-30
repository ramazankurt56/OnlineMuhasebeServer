using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Abstraction;
public interface IJwtProvider
{
    Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user, List<string> roles);
}
using Microsoft.AspNetCore.Identity;

namespace OnlineMuhasebeServer.Domain.Entities.Identity;
public class AppUser:IdentityUser<Guid>
{
    public string FirstName { get; set; }=string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string NameLastName { get; set; } = string.Empty;
    public string RefreshToken { get; set; }= string.Empty;
    public DateTime RefreshTokenExpires { get; set; }
}

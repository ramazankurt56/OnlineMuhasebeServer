using Microsoft.AspNetCore.Identity;

namespace OnlineMuhasebeServer.Domain.Entities.Identity;
public class AppRole:IdentityRole<Guid>
{
    public AppRole()
    {

    }
    public AppRole(string title, string code, string name)
    {
        Code = code;
        Title = title;
        Name = name;
    }

    public string Code { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty ;
}

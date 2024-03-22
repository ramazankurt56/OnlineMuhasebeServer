using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Infrastucture.Context;
public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}

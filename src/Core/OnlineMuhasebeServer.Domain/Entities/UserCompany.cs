using OnlineMuhasebeServer.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.Entities;
public sealed class UserCompany
{
    [ForeignKey("AppUser")]
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
}

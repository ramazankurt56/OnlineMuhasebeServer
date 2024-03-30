using OnlineMuhasebeServer.Domain.Abstraction;
using OnlineMuhasebeServer.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.Entities;
public sealed class MainRoleAppUserAssociation:Entity
{
    public MainRoleAppUserAssociation()
    {
        
    }
    public MainRoleAppUserAssociation( Guid userId, Guid mainRoleId, Guid companyId)
    {
        UserId = userId;
        CompanyId = companyId;
        MainRoleId = mainRoleId;
    }
    [ForeignKey("AppUser")]
    public Guid UserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey("MainRole")]
    public Guid MainRoleId { get; set; }
    public MainRole MainRole { get; set; }

    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
}

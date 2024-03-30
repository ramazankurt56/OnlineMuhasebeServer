using OnlineMuhasebeServer.Domain.Abstraction;
using OnlineMuhasebeServer.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.Entities;
public sealed class MainRoleAppRoleAssociation : Entity
{
    public MainRoleAppRoleAssociation()
    {

    }
    public MainRoleAppRoleAssociation(Guid roleId, Guid mainRoleId)
    {
        RoleId = roleId;
        MainRoleId = mainRoleId;
    }
    [ForeignKey("AppRole")]
    public Guid RoleId { get; set; }
    public AppRole AppRole { get; set; }

    [ForeignKey("MainRole")]
    public Guid MainRoleId { get; set; }
    public MainRole MainRole { get; set; }
}

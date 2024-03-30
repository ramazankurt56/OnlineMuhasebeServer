using OnlineMuhasebeServer.Domain.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.Entities;
public sealed class MainRole : Entity
{
    public MainRole()
    {

    }
    public MainRole(string title, bool isRoleCreatedByAdmin = false, Guid companyId = default)
    {
        Title = title;
        IsRoleCreatedByAdmin = isRoleCreatedByAdmin;
        CompanyId = companyId;
    }

    public string Title { get; set; } = string.Empty;
    public bool IsRoleCreatedByAdmin { get; set; }

    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }

}
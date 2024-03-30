using OnlineMuhasebeServer.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.Entities;
public class AppUserCompanyAssociation
{
    public AppUserCompanyAssociation()
    {

    }

    public AppUserCompanyAssociation(Guid appUserId, Guid companyId) 
    {
        AppUserId = appUserId;
        CompanyId = companyId;
    }
    [ForeignKey("AppUser")]
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
}

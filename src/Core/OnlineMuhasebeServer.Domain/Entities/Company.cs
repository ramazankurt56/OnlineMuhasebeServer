using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.Entities;
public sealed class Company:Entity
{
    public string Name { get; set; }=string.Empty;
    public string Address { get; set; } = string.Empty;
    public string IdentityNumber { get; set; } = string.Empty;
    public string TaxDepartment { get; set; } = string.Empty;
    public string Tel { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

}

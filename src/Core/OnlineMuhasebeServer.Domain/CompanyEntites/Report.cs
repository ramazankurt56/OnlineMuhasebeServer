using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.CompanyEntites;
public sealed class Report : Entity
{
    public string Name { get; set; } = string.Empty;
    public bool Status { get; set; }
    public string FileUrl { get; set; } = string.Empty;
}

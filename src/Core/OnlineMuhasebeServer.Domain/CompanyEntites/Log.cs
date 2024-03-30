using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.CompanyEntites;
public sealed class Log : Entity
{
    public Guid UserId { get; set; }
    public string TableName { get; set; } = string.Empty;
    public string Data { get; set; } = string.Empty;
    public string Progress { get; set; }=string.Empty;
}

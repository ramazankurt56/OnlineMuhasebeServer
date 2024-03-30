namespace OnlineMuhasebeServer.Domain.Dtos;
public sealed class ReportDto
{
    public Guid Id { get; set; }
    public string CompanyId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

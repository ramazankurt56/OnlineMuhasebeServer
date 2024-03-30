using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.CompanyEntites;
public class UniformChartOfAccount:Entity
{
    public string Code { get; set; }=string.Empty;
    public string Name { get; set; } = string.Empty;
    public char Type { get; set; }
}

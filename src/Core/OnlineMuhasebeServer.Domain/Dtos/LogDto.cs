namespace OnlineMuhasebeServer.Domain.Dtos;
public sealed class LogDto
{
    public Guid Id { get; set; } 
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; }= string.Empty;
    public string UserEmail { get; set; } = string.Empty;
    public string TableName { get; set; } = string.Empty;
    public string Progress { get; set; } = string.Empty;
    public string Data { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
}

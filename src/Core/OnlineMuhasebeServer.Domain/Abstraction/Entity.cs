namespace OnlineMuhasebeServer.Domain.Abstraction;
public abstract class Entity
{
    public Entity()
    {
           Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
}

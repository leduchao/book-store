namespace BookStore.Shared.Contract;

public class BaseEntity : ISoftDelete, IAuditEntity
{
    public int Id { get; set; }
    public Guid EntityId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedAt { get; set; }
    public string? CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}

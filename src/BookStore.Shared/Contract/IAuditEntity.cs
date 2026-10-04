namespace BookStore.Shared.Contract;

public interface IAuditEntity
{
    public DateTime CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}

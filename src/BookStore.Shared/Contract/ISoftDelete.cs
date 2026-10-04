namespace BookStore.Shared.Contract;

public interface ISoftDelete
{
    public bool IsDeleted { get; set; }
}

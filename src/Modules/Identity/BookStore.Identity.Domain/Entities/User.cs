using BookStore.Shared.Contract;

namespace BookStore.Identity.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; set; } = null!;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string PasswordHash { get; set; } = null!;
}

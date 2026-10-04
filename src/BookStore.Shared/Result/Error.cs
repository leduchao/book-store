namespace BookStore.Shared.Result;

public class Error(string Code, string Message)
{
    public string Code { get; set; } = Code;
    public string Message { get; set; } = Message;

    public static Error None => new(string.Empty, string.Empty);
}

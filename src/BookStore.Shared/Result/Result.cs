namespace BookStore.Shared.Result;

public class Result
{
    public bool IsSuccess { get; private set; }
    public string? Message { get; private set; }
    public Error? Error { get; private set; }

    protected Result(bool isSuccess, string? message = null, Error? error = null)
    {
        IsSuccess = isSuccess;
        Message = message;
        Error = error;
    }

    public static Result Success(string? message = null) => new(true, message, null);
    public static Result Failure(Error error, string? message = null) => new(false, message, error);
}

public class Result<T> : Result
{
    public T? Data { get; private set; }

    private Result(bool isSuccess, T? data, string? message = null, Error? error = null) 
        : base(isSuccess, message, error)
    {
        Data = data;
    }

    public static Result<T> Success(T? data, string? message = null) => new(true, data, message, null);
    public static new Result<T> Failure(Error error, string? message = null) => new(false, default, message, error);
}

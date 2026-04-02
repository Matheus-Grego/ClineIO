namespace ClineIO.Application.Models;

public class Result
{
    public Result(bool success = true, string message = "")
    {
        IsSuccess = success;
        Message = message;
    }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    
    public static Result Success => new ();
    
    public static Result Failure(string message) => new Result (false, message);
}

public class Result<T> : Result
{
    public Result(T? data, bool success = true, string message = "") : base(success, message)
    {
        Data = data;
    }
    
    public T? Data { get; set; }
    
    
    public static Result<T> Success(T? data) => new (data);
    
    public static Result<T> Failure(T? data, string message) => new (data,false, message);

    
}
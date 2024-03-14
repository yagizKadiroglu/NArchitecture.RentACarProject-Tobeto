namespace Core.CrossCuttingConcerns.Utilities.Results;

public interface IResult
{
    bool Success { get; }
    string Message { get; }
}

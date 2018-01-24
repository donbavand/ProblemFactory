namespace Giphy.Api.Problem
{
    public interface IProblemFactory
    {
        Problem MissingPayLoad(string value);
        Problem UnexpectedError(string value);
    }
}

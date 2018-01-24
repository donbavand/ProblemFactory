using System.Net;

namespace Giphy.Api.Problem
{
    public class ProblemFactory : IProblemFactory
    {
        public Problem MissingPayLoad(string value)
        {
            return new Problem
            {
                Title = "Payload is not well formed or was not provided",
                StatusCode = HttpStatusCode.BadRequest,
                Details = $"Missing Data {value}"
            };
        }

        public Problem UnexpectedError(string value)
        {
            return new Problem
            {
                Title = "There was an error processing you request",
                StatusCode = HttpStatusCode.InternalServerError,
                Details = "An internal error occured. Please retry your request"
            };
        }
    }
}

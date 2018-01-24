using System.Net;

namespace Giphy.Api.Problem
{
    public class Problem
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}

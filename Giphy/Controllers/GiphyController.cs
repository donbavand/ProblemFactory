using System.Threading.Tasks;
using Giphy.Api.Problem;
using Giphy.Libs.Services;
using Microsoft.AspNetCore.Mvc;

namespace Giphy.Api.Controllers
{
    public class GiphyController : Controller
    {
        private readonly IGiphyServices _giphyServices;
        private readonly IProblemFactory _problemFactory;

        public GiphyController(IGiphyServices giphyServices, IProblemFactory problemFactory)
        {
            _giphyServices = giphyServices;
            _problemFactory = problemFactory;
        }

        [HttpGet]
        [Route("v1/giphy/random/{searchCritera?}")]
        public async Task<IActionResult> GetRandomGif(string searchCritera)
        {
            if (string.IsNullOrEmpty(searchCritera))
            {
                return FromProblem(_problemFactory.MissingPayLoad("searchCritera"));
            }

            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(searchCritera);

            return Ok(result);
        }

        public IActionResult FromProblem(Problem.Problem problem)
        {
            return StatusCode((int) problem.StatusCode, problem);
        }
    }
}
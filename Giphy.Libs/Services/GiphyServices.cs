using System.Threading.Tasks;
using Giphy.Libs.Giphy;
using Giphy.Libs.Models;

namespace Giphy.Libs.Services
{
    public class GiphyServices : IGiphyServices
    {
        private readonly IGetRandomGif _getRandomGif;

        public GiphyServices(IGetRandomGif getRandomGif)
        {
            _getRandomGif = getRandomGif;
        }

        public async Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera)
        {
            return await _getRandomGif.ReturnRandomGifBasedOnTag(searchCritera);
        }
    }
}
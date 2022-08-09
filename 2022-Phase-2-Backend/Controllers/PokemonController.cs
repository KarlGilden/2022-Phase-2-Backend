using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2022_Phase_2_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly HttpClient _client;
        /// <summary />
        public PokemonController(IHttpClientFactory clientFactory)
        {
            if (clientFactory is null)
            {
                throw new ArgumentNullException(nameof(clientFactory));
            }
            _client = clientFactory.CreateClient("pokemon");
        }

        [HttpGet]
        [Route("pokemon")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetPokemon()
        {
            var res = await _client.GetAsync("pokemon/ditto");
            var content = await res.Content.ReadAsStringAsync();
          
            return Ok(content);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2022_Phase_2_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedditController : ControllerBase
    {
        private readonly HttpClient _client;
        /// <summary />
        public RedditController(IHttpClientFactory clientFactory)
        {
            if (clientFactory is null)
            {
                throw new ArgumentNullException(nameof(clientFactory));
            }
            _client = clientFactory.CreateClient("reddit");
        }

        [HttpGet]
        [Route("raw")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetRawRedditHotPosts()
        {
            var res = await _client.GetAsync("/hot");
            var content = await res.Content.ReadAsStringAsync();
            return Ok(content);
        }
    }
}

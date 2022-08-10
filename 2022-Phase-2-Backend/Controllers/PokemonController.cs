using _2022_Phase_2_Backend.Data;
using _2022_Phase_2_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2022_Phase_2_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly HttpClient _client;
        private readonly IPokeRepo _repository;

        public PokemonController(IHttpClientFactory clientFactory, IPokeRepo repository)
        {
            if (clientFactory is null)
            {
                throw new ArgumentNullException(nameof(clientFactory));
            }
            _client = clientFactory.CreateClient("pokemon");
            _repository = repository;
        }

        [HttpPost]
        [Route("AddPokemonToTeam")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddPokemonToTeam(string PokemonName, int teamId)
        {
            Team newTeam = _repository.AddPokemonToTeam(PokemonName, teamId);
            return Ok(newTeam);
        }

        [HttpPost]
        [Route("RemovePokemonFromTeam")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> RemovePokemonFromTeam(int teamId, int teamIndex)
        {
            Team t = _repository.RemovePokemonFromTeam(teamId, teamIndex);

            return Ok(t);
        }

        [HttpPost]
        [Route("AddTeam")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> AddTeam()
        {
            Team t = _repository.AddTeam();

            return Ok(t);
        }

        [HttpPost]
        [Route("DeleteTeam")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> DeleteTeam(int teamId)
        {
            Team t = _repository.DeleteTeam(teamId);
            return Ok(t);
        }

        [HttpGet]
        [Route("GetTeam")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetTeam(int teamId)
        {
            Team t = _repository.GetTeam(teamId);

            return Ok(t);
        }

        [HttpGet]
        [Route("GetTeamSummary")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetTeamSummary(int teamId)
        {
            Team team = _repository.GetTeam(teamId);

            string[] teamArray = new string[] { team.Pokemon1, team.Pokemon2, team.Pokemon3, team.Pokemon4, team.Pokemon5, team.Pokemon6 };

            var attack = 0;
            var defense = 0;
            var speed = 0;

            for (var i = 0; i < teamArray.Length; i++)
            {
                var res = await _client.GetAsync("pokemon/" + teamArray[i].ToLower());
                var content = await res.Content.ReadAsStringAsync();

                dynamic a = JObject.Parse(content)["stats"][1]["base_stat"].ToString();
                dynamic d = JObject.Parse(content)["stats"][2]["base_stat"].ToString();
                dynamic s = JObject.Parse(content)["stats"][5]["base_stat"].ToString();

                attack += Int32.Parse(a);
                defense += Int32.Parse(d);
                speed += Int32.Parse(s);

            }
            Summary summary = new Summary()
            {
                TotalAttack = attack,
                TotalDefense = defense,
                TotalSpeed = speed,
                TypesStrongAgainst = "",
                TypesWeakAgainst = "",
                StrengthScore = 0
            };

            return Ok(summary);
        }

    }
}

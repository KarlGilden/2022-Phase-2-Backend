using _2022_Phase_2_Backend.Models;

namespace _2022_Phase_2_Backend.Data
{
    public interface IPokeRepo
    {
        public Team AddPokemonToTeam(string teamPokemonName, int teamId);
        public Team RemovePokemonFromTeam(int teamId, int teamIndex);
        public Team AddTeam();
        public Team DeleteTeam(int teamId);
        public Team GetTeam(int teamId);
    }
}

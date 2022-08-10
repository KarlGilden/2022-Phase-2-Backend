using _2022_Phase_2_Backend.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace _2022_Phase_2_Backend.Data
{
    public class PokeRepo : IPokeRepo
    {
        private readonly PokemonContext _dbContext;
        public PokeRepo(PokemonContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Team AddPokemonToTeam(string teamPokemonName, int teamId)
        {
            var result = _dbContext.Teams.SingleOrDefault(t => t.Id == teamId);
            if (result != null)
            {
                if(result.Pokemon1 == "")
                {
                    result.Pokemon1 = teamPokemonName;
                    _dbContext.SaveChanges();
                    return result;
                }
                if (result.Pokemon2 == "")
                {
                    result.Pokemon2 = teamPokemonName;
                    _dbContext.SaveChanges();
                    return result;

                }
                if (result.Pokemon3 == "")
                {
                    result.Pokemon3 = teamPokemonName;
                    _dbContext.SaveChanges();
                    return result;
                }
                if (result.Pokemon4 == "")
                {
                    result.Pokemon4 = teamPokemonName;
                    _dbContext.SaveChanges();
                    return result;
                }
                if (result.Pokemon5 == "")
                {
                    result.Pokemon5 = teamPokemonName;
                    _dbContext.SaveChanges();
                    return result;
                }
                if (result.Pokemon6 == "")
                {
                    result.Pokemon6 = teamPokemonName;
                    _dbContext.SaveChanges();
                    return result;
                }

                result.Pokemon6 = teamPokemonName;
                _dbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public Team AddTeam()
        {
            EntityEntry<Team> e = _dbContext.Teams.Add(new Team());
            Team t = e.Entity;
            _dbContext.SaveChanges();
            return t;
        }

        public Team DeleteTeam(int teamId)
        {
            var team = _dbContext.Teams.SingleOrDefault(x => x.Id == teamId); //returns a single item.

            if (team != null)
            {
                _dbContext.Teams.Remove(team);
                _dbContext.SaveChanges();
                return team;
            }
            return null;
        }

        public Team GetTeam(int teamId)
        {
            var team = _dbContext.Teams.SingleOrDefault(t => t.Id == teamId);
            if(team != null) return team;

            return null;

        }

        public Team RemovePokemonFromTeam(int teamId, int teamIndex)
        {
            var result = _dbContext.Teams.SingleOrDefault(t => t.Id == teamId);
            if(result != null)
            {
                if(teamIndex == 0)
                {
                    result.Pokemon1 = "";
                    _dbContext.SaveChanges();
                    return result;
                }
                if (teamIndex == 1)
                {
                    result.Pokemon2 = "";
                    _dbContext.SaveChanges();
                    return result;
                }
                if (teamIndex == 2)
                {
                    result.Pokemon3 = "";
                    _dbContext.SaveChanges();
                    return result;
                }
                if (teamIndex == 3)
                {
                    result.Pokemon4 = "";
                    _dbContext.SaveChanges();
                    return result;
                }
                if (teamIndex == 4)
                {
                    result.Pokemon5 = "";
                    _dbContext.SaveChanges();
                    return result;
                }
                if (teamIndex == 5)
                {
                    result.Pokemon6 = "";
                    _dbContext.SaveChanges();
                    return result;
                }
            }
            return null;

        }
    }
}

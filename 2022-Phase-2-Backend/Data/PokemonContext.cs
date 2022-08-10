using _2022_Phase_2_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace _2022_Phase_2_Backend.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}

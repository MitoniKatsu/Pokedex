using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public interface IPokedexDbContext
    {
        DbSet<Pokemon> Pokemon { get; set; }
        DbSet<PokemonSpecies> PokemonSpecies { get; set; }
        DbSet<Type> Type { get; set; }
    }
}
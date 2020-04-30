using Data.Dto;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IPokedexRepository
    {
        int Create(CreatePokemonDto dto);
        void Delete(int id);
        PokemonDto Get(int id);
        IList<PokemonDto> GetList();
        IList<SimpleSpeciesDto> GetSpeciesList();
        int Update(UpdatePokemonDto dto);
    }
}
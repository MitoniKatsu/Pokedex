using Data.Dto;
using Data.Entities;
using Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PokedexRepository : IPokedexRepository
    {
        private IPokedexDbContext _dbContext { get; set; }
        public PokedexRepository(IPokedexDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<PokemonDto> GetList()
        {
            return _dbContext.Pokemon
                .Include(i => i.Species)
                    .ThenInclude(i => i.PrimaryType)
                .Include(i => i.Species)
                    .ThenInclude(i => i.SecondaryType)
                .ToList().toDto();
        }

        public IList<SimpleSpeciesDto> GetSpeciesList()
        {
            return _dbContext.PokemonSpecies
                .ToList()
                .toDto();
        }

        public PokemonDto Get(int id)
        {
            var pokemon = _dbContext.Pokemon
                .Include(i => i.Species)
                    .ThenInclude(i => i.PrimaryType)
                .Include(i => i.Species)
                    .ThenInclude(i => i.SecondaryType)
                .FirstOrDefault(o => o.PokemonID == id).toDto();

            return pokemon;
        }

        public int Create(CreatePokemonDto dto)
        {
            var newPokemon = new Pokemon
            {
                PokemonName = dto.PokemonName,
                SpeciesID = dto.SpeciesID
            };

            if (_dbContext.PokemonSpecies.Any(o => o.SpeciesID == dto.SpeciesID))
            {
                var pokemon = _dbContext.Pokemon.Add(newPokemon);
                _dbContext.SaveChanges();
                return pokemon.Entity.PokemonID;
            }
            else
            {
                throw new KeyNotFoundException($"Species with ID: {dto.SpeciesID} does not exist.");
            }
        }

        public int Update(UpdatePokemonDto dto)
        {
            var pokemon = _dbContext.Pokemon.FirstOrDefault(o => o.PokemonID == dto.PokemonID);

            if (pokemon == null)
            {
                throw new KeyNotFoundException($"Pokemon with ID: {dto.PokemonID} does not exist.");
            }

            if (dto.SpeciesID == null)
            {
                pokemon.PokemonName = dto.PokemonName;
                _dbContext.SaveChanges();
                return pokemon.PokemonID;
            }
            else
            {
                if (_dbContext.PokemonSpecies.Any(o => o.SpeciesID == dto.SpeciesID.Value))
                {
                    pokemon.PokemonName = dto.PokemonName;
                    pokemon.SpeciesID = dto.SpeciesID.Value;
                    _dbContext.SaveChanges();
                    return pokemon.PokemonID;
                }

                throw new KeyNotFoundException($"Species with ID: {dto.SpeciesID} does not exist.");
            }

        }

        public void Delete(DeletePokemonDto dto)
        {
            var pokemon = _dbContext.Pokemon.FirstOrDefault(o => o.PokemonID == dto.PokemonID);

            if (pokemon != null)
            {
                _dbContext.Pokemon.Remove(pokemon);
                _dbContext.SaveChanges();
                return;
            }

            throw new KeyNotFoundException($"Pokemon with ID: {dto.PokemonID} does not exist.");
        }



    }
}

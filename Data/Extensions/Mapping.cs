using Data.Dto;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Extensions
{
    public static class Mapping
    {
        #region Pokemon Mapping
        public static PokemonDto toDto(this Pokemon entity)
        {
            var dto = new PokemonDto
            {
                PokemonID = entity.PokemonID,
                PokemonName = entity.PokemonName,
                PokemonSpecies = new SpeciesDto
                {
                    SpeciesID = entity.Species.SpeciesID,
                    SpeciesName = entity.Species.SpeciesName,
                    Description = entity.Species.SpeciesDescription,
                    PrimaryType = new TypeDto
                    {
                        TypeName = entity.Species.PrimaryType.TypeName
                    },
                    SecondaryType = entity.Species.SecondaryType != null ? new TypeDto
                    {
                        TypeName = entity.Species.SecondaryType.TypeName
                    } : null
                }
            };

            return dto;
        }

        public static IList<PokemonDto> toDto(this IList<Pokemon> entityList)
        {
            List<PokemonDto> dtoList = new List<PokemonDto>();

            foreach (var entity in entityList)
            {
                dtoList.Add(entity.toDto());
            }

            return dtoList;
        }

        public static SimpleSpeciesDto toDto(this PokemonSpecies entity)
        {
            var dto = new SimpleSpeciesDto
            {
                SpeciesID = entity.SpeciesID,
                SpeciesName = entity.SpeciesName
            };

            return dto;
        }

        public static IList<SimpleSpeciesDto> toDto(this IList<PokemonSpecies> entityList)
        {
            List<SimpleSpeciesDto> dtoList = new List<SimpleSpeciesDto>();

            foreach (var entity in entityList)
            {
                dtoList.Add(entity.toDto());
            }

            return dtoList;
        }


        #endregion
    }
}

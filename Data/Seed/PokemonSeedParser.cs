using Data.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Type = Data.Entities.Type;

namespace Data.Seed
{
    public static class PokemonSeedParser
    {
        public static List<Type> GetTypeSeedList()
        {
            var typeList = new List<Type>();

            foreach (int type in Enum.GetValues(typeof(TypesData)))
            {
                var newType = new Type
                {
                    TypeID = type,
                    TypeName = Enum.GetName(typeof(TypesData), type)
                };

                typeList.Add(newType);
            }

            return typeList;
        }

        public static List<PokemonSpecies> GetSpeciesSeedList()
        {
            var speciesList = new List<PokemonSpecies>();

            using (StreamReader seedData = File.OpenText(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\Data\\Seed\\Pokemon.json"))
            {
                var pokemonDataArray = JsonConvert.DeserializeObject<RootObject>(seedData.ReadToEnd());

                foreach (var pokemonData in pokemonDataArray.pokemon)
                {
                    var pokemon = new PokemonSpecies
                    {
                        SpeciesID = pokemonData.id,
                        SpeciesName = pokemonData.name,
                        SpeciesDescription = pokemonData.description,
                        PrimaryTypeID = (int)Enum.Parse(typeof(TypesData), pokemonData.types[0]),
                        SecondaryTypeID = pokemonData.GetSecondaryType(),
                    };

                    speciesList.Add(pokemon);
                }

                return speciesList;
            }
        }

        private static int? GetSecondaryType(this Pokemon pokemon)
        {
            return pokemon.types.Count > 1 ? (int)Enum.Parse(typeof(TypesData), pokemon.types[1]) : (int?)null;
        }

    }
}

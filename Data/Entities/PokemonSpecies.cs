using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PokemonSpecies
    {
        public int SpeciesID { get; set; }
        public string SpeciesName { get; set; }
        public int SpeciesTypeID { get; set; }
        public string SpeciesDescription { get; set; }
        public int? EvolvesFromID { get; set; }
        public int? EvolvesToID { get; set; }
        public int? EvolutionLevel { get; set; }
        public PokemonType SpeciesType { get; set; }
        public PokemonSpecies EvolvesFrom { get; set; }
        public PokemonSpecies EvolvesTo { get; set; }

    }
}

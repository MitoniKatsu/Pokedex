using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Pokemon
    {
        public int PokemonID { get; set; }
        public int SpeciesID { get; set; }
        public string PokemonName { get; set; }
        public PokemonSpecies Species { get; set; }
    }
}

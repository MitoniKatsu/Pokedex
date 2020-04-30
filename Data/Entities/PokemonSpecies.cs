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
        public string SpeciesDescription { get; set; }
        public int PrimaryTypeID { get; set; }
        public int? SecondaryTypeID { get; set; }

        //Navigation Properties
        public Type PrimaryType { get; set; }
        public Type SecondaryType { get; set; }
        public ICollection<Pokemon> Pokemon {get;set;}
    }
}

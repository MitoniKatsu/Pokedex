using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PokemonType
    {
        public int PokemonTypeID { get; set; }
        public int PrimaryTypeID { get; set; }
        public int? SecondaryTypeID { get; set; }
        public Type PrimaryType { get; set; }
        public Type SecondaryType { get; set; }
    }
}

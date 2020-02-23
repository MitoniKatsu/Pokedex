using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    public class CreatePokemonDto
    {
        [Required]
        public string PokemonName { get; set; }
        [Required]
        public int SpeciesID { get; set; }
    }

    public class UpdatePokemonDto
    {
        [Required]
        public int PokemonID { get; set; }
        [Required]
        public string PokemonName { get; set; }
        public int? SpeciesID { get; set; }
    }

    public class DeletePokemonDto
    {
        [Required]
        public int PokemonID { get; set; }
    }

    public class PokemonDto
    {
        public int PokemonID { get; set; }
        public string PokemonName { get; set; }
        public SpeciesDto PokemonSpecies { get; set; }
    }

    public class SpeciesDto
    {
        public int SpeciesID { get; set; }
        public string SpeciesName { get; set; }
        public string Description { get; set; }
        public TypeDto PrimaryType { get; set; }
        public TypeDto SecondaryType { get; set; }
    }

    public class SimpleSpeciesDto
    {
        public int SpeciesID { get; set; }
        public string SpeciesName { get; set; }
    }

    public class TypeDto
    {
        public string TypeName { get; set; }
    }
}

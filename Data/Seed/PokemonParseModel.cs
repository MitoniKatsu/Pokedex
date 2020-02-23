using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seed
{
    public class Evolution
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? from { get; set; }
        public object trigger { get; set; }
        public int? trigger_lvl { get; set; }
        public string trigger_item { get; set; }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string base_experience { get; set; }
        public string description { get; set; }
        public List<string> types { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public List<Evolution> evolutions { get; set; }
    }

    public class RootObject
    {
        public List<Pokemon> pokemon { get; set; }
    }

    public enum TypesData
    {
        normal = 1,
        fighting,
        flying,
        poison,
        ground,
        rock,
        bug,
        ghost,
        steel,
        fire,
        water,
        grass,
        electric,
        psychic,
        ice,
        dragon,
        dark,
        fairy
    }
}

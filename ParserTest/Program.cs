using Data.Seed;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<RootObject>();

            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            using (StreamReader file = File.OpenText(Directory.GetCurrentDirectory() + "\\" + "Seed\\Pokemon.json"))
            {
                var pokemonData = JsonConvert.DeserializeObject<RootObject>(file.ReadToEnd());

                pokemonData.pokemon.ForEach(p => {
                    var typeString = string.Join('-', p.type);
                    Console.WriteLine($"id: {p.id}, name: {p.name.english} type: {typeString}");
                });
            }
        }
    }
}

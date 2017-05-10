using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PokeCalc.Models
{
    [Table("Pokemons")]
    public class Pokemon
    {
        [Key]
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public List<Move> Moves { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}

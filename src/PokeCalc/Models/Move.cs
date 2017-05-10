using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PokeCalc.Models
{
    [Table("Moves")]
    public class Move
    {
        [Key]
        public int MoveId { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {

        public string name { get; set; }
        public string characterClass { get; set; }
        public int HitPoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}

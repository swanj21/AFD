using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Player
    {
        public string playerName { get; set; }
        public string charClass { get; set; }
        public int hitPoints { get; set; }
        public int expPoints { get; set; }
        public int level { get; set; }
        public int gold { get; set; }
    }
}

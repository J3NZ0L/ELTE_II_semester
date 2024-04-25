using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9.StarshipTypes
{
    public class Lasership : Starship
    {
        public Lasership(string name, int shield, int armor, int guardian) : base(name, shield, armor, guardian)
        {
        }

        override public double FireP()
        {
            return shield;
        }
    }
}

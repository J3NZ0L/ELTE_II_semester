using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Planet
    {
        public string name;

        private List<Starship> ships;

        public Planet(string name)
        {
            this.name = name;
            this.ships= new List<Starship>();
        }

        public void Defends(Starship s)
        {
            if (ships.Contains(s)){
                throw new Exception("Ship is already in defense line");
            }
            ships.Add(s);
        }

        public void Leaves(Starship s)
        {
            if (!ships.Contains(s))
            {
                throw new Exception("Ship not found in defense line");
            }
            ships.Remove(s);
        }

        public int ShipCount()
        {
            return ships.Count;
        }

        public int ShieldSum()
        {
            int sum = 0;
            foreach(Starship e in ships) {
                sum += e.GetShield();
            }
            return sum;
        }

        public (bool, double, Starship?) MaxFireP()
        {
            if (ships.Count == 0)
            {
                return (false, 0.0, null);
            }
            double max =  0;
            Starship? maxe = null;
            bool l = false;
            foreach(Starship e in ships)
            {
                if (max < e.FireP())
                {
                    l = true;
                    max = e.FireP();
                    maxe = e;
                }
            }
            return (l, max, maxe);
        }
    }
}

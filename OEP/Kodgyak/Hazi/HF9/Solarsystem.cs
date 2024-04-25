using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Solarsystem
    {
        public List<Planet> planets;

        public Solarsystem()
        { 
            this.planets = new List<Planet>();
        }

        public (bool, Starship?) MaxFireP()
        {
            
            if (planets.Count == 0)
            {
                return (false, null);
            }
            
            Starship maxship = null;
            
            (_, double max, maxship) = planets[0].MaxFireP();
            double currmax;
            Starship currship = null;
            bool l = false;
            foreach (Planet e in planets)
            {
                
                (_,currmax, currship) = e.MaxFireP();
                if (max < currmax)
                {
                    l = true;
                    max = currmax;
                    maxship = currship;
                }
            }
            return (l, maxship);
        }

        public List<Planet> Defenseless()
        {
            List<Planet> defenselessPlanets = new List<Planet> ();
            foreach (Planet e in planets)
            {
                if (e.ShipCount() == 0)
                {
                    defenselessPlanets.Add(e);
                }
            }
            return defenselessPlanets;
        }
    }
}

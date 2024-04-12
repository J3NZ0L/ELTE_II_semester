using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    public  class Fisherman
    {
        public string Name { get; }
        public List<Catch> _catches;

        public Fisherman(string name) {
            this.Name = name;
            _catches = new List<Catch>();
        }
        public void AddCatch(Catch c)
        {
            _catches.Add(c);
        }
        public int TotalCarpWeight()
        {
            int sum = 0;
            foreach (Catch c in _catches)
            {
                if ( c.Species == "Ponty" && c.Length >= 50) { 
                sum+= c.Weight;
                }
            }
            return sum;
        }
    }
}

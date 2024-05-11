using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF10
{
    public class TargetShot
    {
        private string site;
        private HashSet<Gift> gifts;

        public HashSet<Gift> GetGifts() { return gifts; }
        public TargetShot(string s)
        {
            site = s;
            gifts = new HashSet<Gift>();
        }

        public void Shows(Gift g)
        {
            if (g.targetShot != null)
            {
                throw new Exception("");
            }
            if (gifts.Contains(g))
            {
                throw new Exception("");
            }
            g.targetShot = this;
            gifts.Add(g);
        }
    }
}

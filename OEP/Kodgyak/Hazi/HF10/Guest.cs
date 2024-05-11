using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HF10
{
    public class Guest
    {
        private string name;

        public string getName()
        {
            return name;
        }

        private HashSet<Gift> prizes;

        public Guest(string name)
        {
            this.name = name;
            this.prizes = new HashSet<Gift>();
        }

        public void Wins(Gift g)
        {
            if (g.targetShot != null)
            {
                if (!g.targetShot.GetGifts().Contains(g))
                {
                    throw new Exception("");
                }
                g.targetShot.GetGifts().Remove(g);
                prizes.Add(g);
            }
            else throw new NullReferenceException();
        }

        public int Result(TargetShot t)
        {
            int sum=0;
            foreach(Gift e in prizes)
            {
                if (e.targetShot == t)
                {
                    sum += e.Value();
                }
            }
            return sum;
        }
    }

}

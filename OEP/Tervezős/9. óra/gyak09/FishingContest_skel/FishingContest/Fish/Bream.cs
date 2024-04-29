using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest.Fish
{
    internal class Bream : IFish
    {
        private static Bream? instance;
        public static Bream? Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bream();
                }
                return instance;
            }
        }

        protected Bream()
        {

        }

        public int Multiplier() => 2;
    }
}

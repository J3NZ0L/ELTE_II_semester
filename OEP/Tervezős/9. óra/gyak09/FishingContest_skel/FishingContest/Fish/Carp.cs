using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest.Fish
{
    internal class Carp
    {
        private static Carp? instance;
        public static Carp? Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Carp();
                }
                return instance;
            }
        }

        protected Carp()
        {

        }

        public int Multiplier() => 1;
    }
}

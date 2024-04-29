using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest.Fish
{
    internal class Catfish
    {
        private static Catfish? instance;
        public static Catfish? Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Catfish();
                }
                return instance;
            }
        }

        protected Catfish()
        {

        }

        public int Multiplier() => 3;
    }
}

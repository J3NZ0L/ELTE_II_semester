using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HF10.Sizes
{
    public sealed class M : Size
    {
        private static M? instance =null;

        private M()
        {
        }

        public static M Instance()
        {
            if (instance == null)
            {
                instance = new M();
            }
            return instance;
        }

        public int Multi()
        {
            return 2;
        }
    }
   

}

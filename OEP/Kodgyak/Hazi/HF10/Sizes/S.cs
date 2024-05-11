using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HF10.Sizes
{
    public sealed class S : Size
    {
        private static S? instance = null;

        private S()
        {
        }

        public static S Instance()
        {
            if (instance == null)
            {
                instance = new S();
            }
            return instance;
        }


        public int Multi()
        {
            return 1;
        }
    }
   

}

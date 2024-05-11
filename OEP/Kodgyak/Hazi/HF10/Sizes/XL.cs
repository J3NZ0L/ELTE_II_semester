using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HF10.Sizes
{
    public sealed class XL : Size
    {
        private static XL? instance = null;

        private XL()
        {
        }

        public static XL Instance()
        {
            if (instance == null)
            {
                instance = new XL();
            }
            return instance;
        }

        public int Multi()
        {
            return 4;
        }
    }
   

}

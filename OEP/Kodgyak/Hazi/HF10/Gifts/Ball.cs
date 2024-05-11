using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF10.Gifts
{
    internal class Ball : Gift
    {
        public Ball(Size size) : base(size)
        { }

        public override int Point()
        {
            return 1;
        }
    }
}

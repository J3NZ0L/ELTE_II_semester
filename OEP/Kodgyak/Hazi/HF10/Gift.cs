using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF10
{
    public class Gift
    {
        private Size size;

        public TargetShot? targetShot;

        public Gift(Size size)
        {
            this.size = size;
        }
        public int Value()
        {
            return Point() * size.Multi();
        }

        public virtual int Point()
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF8
{
    internal class Folder : Registration
    {
        private List<Registration> items;
        public Folder() {
            this.items = new List<Registration>();
        }
        public override int GetSize()
        {
            int sum=0;
            foreach(Registration reg in items)
            {
                sum += reg.GetSize();                
            }
            return sum;
        }
        public void Add(Registration r)
        {
            items.Add(r);        
        }

        public void Remove(Registration r)
        {
            items.Remove(r);
        }
    }
}

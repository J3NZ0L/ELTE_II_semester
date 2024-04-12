using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlas
{
    internal class Department
    {
        private List<Product> stock = [];
        //ne csinaljuk igy
        public List<Product> Stock { 
            get => stock; 
            init => stock = value; 
        } 
    }
}

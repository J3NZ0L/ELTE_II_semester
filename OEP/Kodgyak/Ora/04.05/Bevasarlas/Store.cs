using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlas
{
    internal class Store
    {
        public Department Food { get; }
        public Department Tech { get; }

        public Store()
        {
            Food = new Department()
            {
                Stock = [new Product("sausage", 300), new Product("sausage", 450), new Product("sausage", 200), new Product("kenyere", 600)]
            };
            Tech = new Department()
            {
                Stock = [new Product("Computer", 600), new Product("WinRar", 0), new Product("Computer", 400), new Product("xz-utils", -60)]
            };
        }
        public override string ToString()
        {
            return "Food: " + string.Join(',', Food.Stock) + "\nTech: " + string.Join(',', Tech.Stock);
        }
    }
}

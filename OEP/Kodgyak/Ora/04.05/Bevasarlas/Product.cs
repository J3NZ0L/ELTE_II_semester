using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevasarlas
/*
{
internal class Product
{
    public string Name { get; }
    public int Price { get; }
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
    //ctorp -> propertyre koncstruktor
    //ctorf -> member
    //ctor -> ures konstr.


}
}
*/
//helyett lehet hasznalni recordokat hasznalni ha lustak vagyunk
{
    public record Product(string Name, int Price);
}
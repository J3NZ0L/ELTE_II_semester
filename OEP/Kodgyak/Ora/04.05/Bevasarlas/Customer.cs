using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Bevasarlas
{
    internal class Customer
    {
        private string[] list;
        private List<Product> basket;

        public Customer(string[] list)
        {
            this.list = list;         
            this.basket = new List<Product>();
        }
        public void GoShopping(Store store)
        {
            foreach(string item in list)
            {
                Product? product = Find(item, store.Food);
                if (product != null)
                {
                    Buy(product, store.Food);
                }
            }
            foreach (string item in list)
            {
                Product? product = FindCheap(item, store.Tech);
                if (product != null)
                {
                    Buy(product, store.Tech);
                }
            }
        }

        private void Buy(Product prod, Department dept)
        {
            dept.Stock.Remove(prod);
            basket.Add(prod);
           
        }
        private static Product? Find(string name, Department dept)
        {
            foreach(Product p in dept.Stock)
            {
                if (p.Name == name) return p;

            }
            return null;
        }

        private static Product? FindCheap(string name, Department dept)
        {
            Product minp = null;
            foreach(Product p in dept.Stock)
            {
                
                if (!p.Name.Equals(name)) { }
                else if (minp==null)
                {
                    minp = p;
                }
                else
                {
                    if (minp.Price>p.Price)
                    {
                        minp = p;
                    }
                }
                
            }
            return minp;
            //return dept.Stock.FindAll(p => p.Name == name).MaxBy(p => p.Price);
        }

        public override string ToString()
        {
            return "List: " + string.Join(',', list) + "" + "\nBasket: " + string.Join(',', basket);

        }
    }
}

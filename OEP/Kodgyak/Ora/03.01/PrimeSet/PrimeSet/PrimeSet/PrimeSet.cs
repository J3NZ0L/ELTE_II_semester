using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSet
{
    public class PrimeSet
    {
        private int n;
        public PrimeSet()
        {
            n = 1;

        }
        public bool Int(int p) => n % p == 0;
        public void Add(int p)
        {
            if (n % p == 0)
            {
                throw new ArgumentException("Already in set.", nameof(p));
                n *= p;
            }
        }
        public void Remove(int p)
        {
            if (n % p != 0) {
                throw new ArgumentException("Not in set. ", nameof(p));
            }
            n /= p;

        }
        public bool Empty() => n == 1;
        public void SetEmpty()
        {
            n = 1;
        }
        public int Size
        {
            get
            {
                (int c, int m, int i) = (0, n, 2);
                while (m > 1)
                {
                    if (m%i == 0)
                    {
                        ++c;
                        m /= i;
                    }
                    ++i;
                }
                return c;
            }
        }
    }
}

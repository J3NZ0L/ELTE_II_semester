using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1
{
    

    public class Rational
    {
        private int n;
        private int d;

        public Rational(int i, int j)
        {
            if (j == 0)
            {
                throw new Exception();
            } else
            {
                this.n = i;
                this.d = j;
            }
        }

        public static Rational Add(Rational a, Rational b)
        {
            return new Rational (a.n * b.d + a.d * b.n, a.d * b.d);
        }

        public static Rational Substract(Rational a, Rational b)
        {
            return new Rational(a.n * b.d - a.d * b.n, a.d * b.d);
        }
        public static Rational Multiply(Rational a, Rational b)
        {
            return new Rational(a.n * b.n, a.d*b.d);
        }

        public static Rational Divide(Rational a, Rational b)
        {
            if (b.n == 0)
            {
                throw new Exception();
            }
            return new Rational (a.n*b.d, a.d*b.n);
        }

        public static Rational operator +(Rational a, Rational b)
        {
            return Add(a, b);
        }
        public static Rational operator -(Rational a, Rational b)
        {
            return Substract(a, b);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            return Multiply(a, b);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            return Divide(a, b);
        }

        public override string ToString() //feluldefinialas
        {
            return $"{n}/{d}";
        }
    }
}

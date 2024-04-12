using System;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vector null = new Vector(0, 0);
            Vector zero = new Vector();

            Vector oneZero = new Vector(1, 0);
            Vector zeroOne = new Vector(0, 1);
            Vector linComb = new Vector(0.34, 0.4);
            Vector notSure = new Vector(2.54, 1.6);

            Console.WriteLine($"(0,0) is orthogonal: {Orthogonal(zero, oneZero, notSure)}");
            Console.WriteLine($"(1,0) is orthogonal: {Orthogonal(oneZero, zeroOne)}");
            Console.WriteLine($"(0.34,0.34) is orthogonal: {Orthogonal(linComb, oneZero, zeroOne)}");
            Console.WriteLine($"notSure is orthogonal to all the others: {Orthogonal(notSure, zero, oneZero, zeroOne, linComb)}");
        }

        static bool Orthogonal(Vector w, params Vector[] v)
        {
            Vector s = new Vector();
            foreach (Vector vec in v)
            {
                s += vec;
            }

            // return w * s == 0;
            return w * s < Double.Epsilon * 16;
        }
    }
}

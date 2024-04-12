using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace Complex;

public class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        try
        {
            Console.Write("z1 = ");
            string input = Console.ReadLine() ?? "";
            Complex z1 = Complex.Parse(input);
            Console.Write("z2 = ");
            input = Console.ReadLine() ?? "";
            Complex z2 = Complex.Parse(input);

            Console.WriteLine($"z1 + z2 = {z1 + z2}");
            Console.WriteLine($"z1 - z2 = {z1 - z2}");
            Console.WriteLine($"z1 * z2 = {z1 * z2}");
            Console.WriteLine($"z1 / z2 = {z1 / z2}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }


    }
}


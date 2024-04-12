using System;

namespace Dispenser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispenser disp = new Dispenser(100, 5);

            Console.WriteLine($"Content after creation: {disp.Actual}");
            
            disp.Press();
            Console.WriteLine($"Content after pressing the button: {disp.Actual}");

            disp.Refill();
            Console.WriteLine($"Content after a refill: {disp.Actual}");

            for (int i = 1; i < 16; ++i)
            {
                disp.Press();
                Console.WriteLine($"Content after {i} refills: {disp.Actual}");
            }

            disp.Refill();
            Console.WriteLine($"Content after a refill: {disp.Actual}");

            for (int i = 0; i < 30; ++i)
            {
                disp.Press();
            }
            Console.WriteLine($"Content after 30 presses: {disp.Actual}");
        }
    }
}

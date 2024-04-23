using System;
using TextFile;

namespace Bag;

class Program
{
    static void Main()
    {
        try
        {
            using TextFileReader reader = new("input.txt");

            Bag bag = new();

            while (reader.ReadString(out string elem))
            {
                bag.Insert(elem);
            }

            Console.WriteLine($"The most frequent element: {bag.Max()}");
            
            Console.WriteLine($"The contents of the bag: {bag}");
            
            bag.Remove("barack");
            bag.Remove("korte");
            
            Console.WriteLine($"The contents of the bag: {bag}");

            Console.WriteLine($"Number of baracks: {bag.Multipl("barack")}");
            Console.WriteLine($"Number of szilvas: {bag.Multipl("szilva")}");
            Console.WriteLine($"Number of almas: {bag.Multipl("alma")}");
            
            bag.SetEmpty();
            Console.WriteLine($"There most frequent element: {bag.Max() ?? "bag is empty"}");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("Input file does not exist");
        }
    }
}
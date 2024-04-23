using System.Globalization;

namespace LowerTriangleMatrix;

class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Menu menu = new Menu();
        menu.Run();
    }
}
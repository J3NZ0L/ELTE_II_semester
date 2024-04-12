using System;
using System.Globalization;
using System.IO;
using System.Threading;
using TextFile;

namespace Geometry;

class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        
        try
        {
            using TextFileReader r = new TextFileReader("input.txt");

            r.ReadDouble(out double cx);
            r.ReadDouble(out double cy);
            r.ReadDouble(out double cr);
            Circle c = new Circle(new Point(cx, cy), cr);
            // Circle c = new Circle(new Point(r.ReadDouble()!, r.ReadDouble()!), r.ReadDouble()!);

            r.ReadInt(out int n);
            Point[] points = new Point[n];
            for (int i = 0; i < n; ++i)
            {
                r.ReadDouble(out double x);
                r.ReadDouble(out double y);
                points[i] = new Point(x, y);
            }

            int cnt = 0;
            foreach (Point p in points)
            {
                if (c.Contains(p)) ++cnt;
            }

            Console.WriteLine($"A körlemezre eső pontok száma: {cnt}.");
        }
        catch (FileNotFoundException ex)
        {
            Console.Error.WriteLine("Nem létezik a fájl.");
        }
        catch (IOException ex)
        {
            Console.Error.WriteLine("Nem lehet olvasni a fájlt: " + ex);
        }
        catch (Circle.IllegalRadiusException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}
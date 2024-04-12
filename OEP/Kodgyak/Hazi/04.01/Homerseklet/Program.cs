using TextFile;

namespace Homerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using TextFileReader reader = new TextFileReader(args[0]);
            double s = 0.0;
            int db = 0;
            double e;
            bool st = reader.ReadDouble(out e);
            while (st && e >= 0)
            {
                s = s + e;
                db++;
                st = reader.ReadDouble(out e);
            }
            double a = s / db;
            bool l = true;
            double kicsi = e;
            st = reader.ReadDouble(out e);
            while (st)
            {
                l = l && e < 0;
                if (e < kicsi)
                {
                    kicsi = e;
                }
                st= reader.ReadDouble(out e);
            }
            Console.WriteLine(a);
            Console.WriteLine(l);
            Console.WriteLine(kicsi);
        }
    }
}

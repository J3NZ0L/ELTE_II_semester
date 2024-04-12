using TextFile;

namespace szamos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using TextFileReader reader = new TextFileReader();

            int db = 0;
            //int? e
            //while ((e = reader
            while(reader.ReadInt(out int e) && e >= 0)
            {
                if (e % 2 == 0) ++db;
            }
            Console.WriteLine(db);
        }
    }
}

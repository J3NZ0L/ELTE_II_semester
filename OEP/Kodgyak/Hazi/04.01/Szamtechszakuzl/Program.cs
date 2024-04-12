using TextFile;

namespace Szamtechszakuzl
{
    public record Áru
    {
        public string cikkszám;
        public int ár;
    }
    public record Számla
    {
        public string név;
        public List<Áru> lista;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            using TextFileReader reader = new TextFileReader(args[0]);
            int bevét = 0;
            bool st;
            Számla sz=new Számla();
            st = reader.ReadString(out string line);
            int i;
            while (st)
            {
                string[] li = line.Split(' ');
                sz.név = li[0];
                i = 1;
                while (i <= li.Length) {
                    
                }
            }
            
        }

        static int sum(List<Áru> x)
        {
            int s = 0;
            foreach(Áru e in x)
            {
                s = s + e.ár;
            }
            return s;
        }
    }
}

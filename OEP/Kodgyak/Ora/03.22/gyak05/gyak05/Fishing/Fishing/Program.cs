using TextFile;
namespace Fishing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catch c = new Catch { Time = "20.22", Species = "Carp", Length = 22, Weight = 15 };

            _ = c with { Species = "Béla" };

            bool l = false;
            string name = "";
            using TextFileReader reader = new TextFileReader("input_fishing.txt");
            while (!l && reader.ReadLine(out string line))
            {
                string[] tmp = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Fisherman fisherman = new Fisherman(tmp[0]);
                for (int i = 1; i < tmp.Length; i += 4)
                {
                    string time = tmp[i];
                    string species = tmp[i + 1];
                    int length = int.Parse(tmp[i + 2]);
                    int weight = int.Parse(tmp[i + 3]);
                    Catch ca = new Catch(time, species, length, weight);

                    fisherman.AddCatch(ca);
                }

                if (fisherman.TotalCarpWeight() >= 10)
                {
                    l = true;
                    name = fisherman.Name;
                }

            }
            Console.WriteLine(l);
            Console.WriteLine(name);

        }
    }
}

namespace Garden;

class Program
{
    static void Main(string[] args)
    {
        Gardener gardener = new Gardener();
        
        Console.WriteLine(gardener);
        
        gardener.TendToGarden();
        
        Console.WriteLine(gardener);

        var reap = gardener.garden.Ripe(5);
        Console.WriteLine(string.Join(' ', reap));
        foreach (int i in reap)
        {
            gardener.garden.Reap(i);
        }
        
        Console.WriteLine(gardener);
        
        Console.WriteLine("That's why you should hide your inner state...");
    }
}
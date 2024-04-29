namespace Hunter;

public class Hunter
{
    public string Name { get; }
    public string BirthYear { get; }

    private List<Trophy> trophies;
    
    public Hunter(string name, string birthYear)
    {
        Name = name;
        BirthYear = birthYear;
        trophies = new List<Trophy>();
    }

    public void Drop(string where, string when, Prey what)
    {
        trophies.Add(new Trophy(where, when, what));
    }

    public int CountMaleLions()
    {
        
    }

    public bool MaxHornWeight(out double weight, out Trophy? trophy)
    {
        
    }

    public bool HasEqualFangLength()
    {
        
    }
}
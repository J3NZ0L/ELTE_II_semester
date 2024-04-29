using FishingContest.Fish;
using System.ComponentModel;

namespace FishingContest;

public class Fisherman
{
    public string Name { get; }
    // fogások {unique} ennel a megoldas h ott peldanyositjuk le, emiatt unique lesz

    private List<Catch> catches;
    // ctorfp
    public Fisherman(string name)
    {
        this.catches = new List<Catch>();
        this.Name = name;
    }

    public void Catch(DateTime time, IFish fish, double weight, Competition competition)
    {
        // new Catch(fish, weight, time, competition);

        foreach(Catch c in catches)
        {
            if (c.Time == time)
            {
                throw new InvalidOperationException("Fisherman tries to commit catch fraud");
            }
        }
        catches.Add(new Catch(fish,weight, time, competition));
    }

    public double TotalValue(Competition competition)
    {
        double s = 0.0;

        foreach(Catch c in catches)
        {
            if(c.Competition == competition)
            {
                s += c.Value();
            }
        }
        return s;
    }

    public bool HasCatfish(Competition competition)
    {
        bool b = false;
        int i = 0;
        while (!b && i < catches.Count)
        {
            b = catches[i].Fish is Catfish && catches[i].Competition==competition;
            i++;
        }
        return b;
        /*
        foreach(Catch c in catches)
        {
            if (c.Fish is Catfish && c.Competition == competition)
            {
                return true;
            }
        }
        return false;
        */
    }
}
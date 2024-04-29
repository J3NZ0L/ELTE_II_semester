using FishingContest.Fish;

namespace FishingContest;

public class Catch
{
    public DateTime Time { get; } // immutable class
    public Competition? Competition { get; }

    public IFish Fish { get; }
    private double weight;
    private Fisherman Fisherman;
    

    // ctorfp
    public Catch(IFish Fish, double weight, DateTime time, Competition? competition = null)
    {
        this.Fish = Fish;
        this.weight = weight;
        Time = time;
        Competition = competition;
    }

    public double Value()
    {
        return this.weight * Fish.Multiplier();        
    }


}
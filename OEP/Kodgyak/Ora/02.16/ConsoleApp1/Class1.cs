using System;
namespace Dispenser;

public class Dispenser
{
    private int total;
    private int portion;
    private int actual;

    public Dispenser(int k, int e)
    {
        total = k;
        portion = e;
        actual = 0;
    }

    public int Total { 
        get { 
            return total; 
        }
        private set { total = value; }
    }

    public int Portion
    {
        get => portion;
    }

    public void Press()
    {
        actual = Math.Max(actual - portino, 0);
        //actual = Math.Clamp(actual - portion, 0, total);

    }
    public void Refill()
    {
        actual = total;
    }
}
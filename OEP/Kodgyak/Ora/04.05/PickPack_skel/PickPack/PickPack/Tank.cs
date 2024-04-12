namespace PickPack;

public class Tank
{
    public int Level { get; private set; }
    public int Max {  get; }

    public Tank(int max)
    {
        this.Max = max;
        Level = max;
    }
    public void UseFuel(int litres)
    {
        if (litres > Level || litres < 0)
        {
            throw new ArgumentOutOfRangeException("Too low fuel level");
        }
        Level -= litres;

    }

    public void ReFuel(int litres)
    {
        Level = Math.Clamp(Level + litres, 0, Max);
    }
}
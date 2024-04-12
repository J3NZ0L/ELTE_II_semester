namespace Garden;

public class Gardener
{
    public Garden garden = new Garden(5);

    public void TendToGarden()
    {
        Parcel.CurrentMonth = 3;
        
        // ...
        garden.Plant(0, Onion.Instance);
        garden.Plant(1, Onion.Instance);
        garden.Plant(2, Rose.Instance);
        garden.Plant(4, Potato.Instance);
    }

    public override string ToString()
    {
        return "My garden:\n" + garden.ToString();
    }
}
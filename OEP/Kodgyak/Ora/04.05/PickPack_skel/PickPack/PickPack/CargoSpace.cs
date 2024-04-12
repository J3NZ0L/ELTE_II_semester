namespace PickPack;

public class CargoSpace
{
    private int capacity;
    private List<Cargo> cargolist;

    public bool IsEmpty => cargolist.Count==0;
    public bool IsFull => cargolist.Count==capacity;

    public CargoSpace(int capacity)
    {
        this.capacity = capacity;
        cargolist = new List<Cargo>();
    }
    public void PutIn(Cargo c)
    {
        if (IsFull)
        {
            throw new InvalidOperationException("CargoSpace is full");

        }
        cargolist.Add(c);
    }
    public void TakeOut(Cargo c)
    {
        Cargo cargo = Select();
        //Select should be deterministic
        cargolist.Remove(cargo);
    }

    public Cargo Select()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("CargoSpace is empty");
        }
        return cargolist[0];

    }


}
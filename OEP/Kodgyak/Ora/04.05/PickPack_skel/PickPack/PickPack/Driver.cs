using System.Net.Http.Headers;

namespace PickPack;

public class Driver
{
    public string Base { get; }
    private Vehicle car;


    public Driver(string @base)
    {
        Base = @base;
        car = new Vehicle(12, Base);
    }

    public void Work()
    {
        //ide ne legyen main
        while (true)
        {
            if (car.CargoSpace.IsEmpty)
            {
                Back();
            }
            else Carry();
        }
    }

    private void Back()
    {
        
            if (car.Location != Base)
            {
                Travel(Base);
            }
            while (car.)
        while (!car.CargoSpace.isFull)
            {
                car.CargoSpacce.PutIn(GetCargo());
            }
    }

    private void Carry()
    {
        Cargo cargo = car.CargoSpace.Select();
        Travel(cargo.Address);
        car.CargoSpace.TakeOut();
    }

    private void Travel(string address)
    {
        int litres = car.Check(address);
        if ( litres > 0)
        {
            car.Refuel(litres);
        }
        car.Drive(address);
    }

    private Cargo GetCargo()
    {
        if (car.Location != Base)
        {
            throw new InvalidOperationException("nno cargo here");
        }
        return new Cargo(new Random().Next().ToString);
    }
}
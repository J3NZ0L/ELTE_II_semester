namespace PickPack;

public class Vehicle
{
    private double fuelConsumption;
    private string Location;
    private Tank tank;
    private readonly CargoSpace cargoSpace;
    // changed from the original


    public Vehicle(int fuelConsumption, string Location)
    {
        this.fuelConsumption = fuelConsumption;
        this.Location = Location;
        this.tank = new Tank(50);
        this.cargoSpace = new CargoSpace(12);
    }

    public int Check(string address)
    {
        int litres = Distance(address) * fuelConsumption;
        return Math.Max(litres,tank.Level)
    }

    public void Refuel(int amount)
    {
        
    }

    public void Drive(string address)
    {
        tank.UseFuel(Distance(address));
        Location = address;
    }

    private int Distance(string address)
    {
        return address = Location ? 0 : 1;
    }
}
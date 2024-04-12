namespace Garden;

public class Parcel
{
    private Plant? plantSpecies;
    private int plantingTime;

    public static int CurrentMonth;

    public Parcel()
    {
        plantingTime = 0;
        plantSpecies = null;
    }

    public void Plant(Plant plant)
    {
        if (plantSpecies != null)
        {
            throw new InvalidOperationException("This parcel is already full of " + plantSpecies.GetType().Name);
        }

        plantSpecies = plant;
        plantingTime = CurrentMonth;
    }

    public bool IsRipe(int month)
    {
        //plantSpecies is Vegetable veg;
        //  plantSpecies !=null && plantSpecies.IsVegetable;
        return plantSpecies is Vegetable
             && month - plantingTime == plantSpecies.ripeTime;
        
    }

    public void Reap() => plantSpecies = null;

    public override string ToString()
    {
        if (plantSpecies == null) return "Empty parcel";
        return $"Parcel with {plantSpecies.GetType().Name}.";
    }
}
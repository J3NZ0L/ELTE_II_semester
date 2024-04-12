namespace Garden;

public class Garden
{
    private List<Parcel> parcels;

    public Garden(int parcelCount)
    {
        //parcels = Enumerable.Range(0, parcelCount).Select(_ => new Parcel()).ToList();
        parcels = new List<Parcel>();
        for ( int i=0; i< parcelCount; ++i)
        {
            parcels.Add(new Parcel());
        }
    }

    public void Plant(int where, Plant species)
    {
        parcels[where].Plant(species);
    }

    public void Reap(int where)
    {
        parcels[where].Reap();
    }

    public List<int> Ripe(int month)
    {
        List<int> res=new List<int>();
        for (int i= 0; i<parcels.Count; ++i)
        {
            if (parcels[i].IsRipe(month))
                res.Add(i);
        }
        return res;
    }

    public override string ToString()
    {
        return string.Join('\n', parcels);
    }
}
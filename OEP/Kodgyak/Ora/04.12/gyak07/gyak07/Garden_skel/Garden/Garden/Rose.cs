namespace Garden;

public class Rose : Flower
{
    private static Rose? instance;

    public static Rose Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Rose();
            }
            return instance;
        }
    }
    private Rose() { }
}
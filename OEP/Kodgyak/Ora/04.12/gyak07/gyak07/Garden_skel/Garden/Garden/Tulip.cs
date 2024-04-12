namespace Garden;

public class Tulip : Flower
{
    private static Tulip? instance;

    public Tulip Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Tulip();
            }
            return instance;
        }
    }

    private Tulip() { }
}
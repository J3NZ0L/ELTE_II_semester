namespace Garden;

public class Peas : Vegetable
{
    private static Peas? instance;

    public Peas Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Peas();
            }
            return instance;
        }
    }
    private Peas()
    {
        ripeTime = 1;
    }
}
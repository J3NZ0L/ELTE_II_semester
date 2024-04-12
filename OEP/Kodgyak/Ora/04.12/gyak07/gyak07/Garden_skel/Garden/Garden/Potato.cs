namespace Garden;

public class Potato : Vegetable
{
    private static Potato? instance;

    public static Potato Instance
    {
        get
        {
            if ( instance == null)
            {
                instance = new Potato();
            }
            return instance;
        }
    }
    
    private Potato()
    {
        ripeTime = 2;
    }
}
namespace Garden;

public class Onion : Vegetable
{
    private static Onion? instance;

    public static Onion Instance
    {
        get
        {
            instance ??= new Onion(); //ha bal null akkor jobboldali teljesul
            return instance;
        }
    }

    private Onion()
    {
        ripeTime = 3;
    }
}
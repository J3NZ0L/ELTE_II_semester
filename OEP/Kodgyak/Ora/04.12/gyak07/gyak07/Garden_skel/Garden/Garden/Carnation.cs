namespace Garden;

public class Carnation : Flower
{
    private static Carnation? instance;
    public static Carnation? Instance => instance ?? (instance = new Carnation());

    private Carnation()
    {
        ripeTime = 15;
    }
}
namespace Hunter;

public class Trophy
{
    private Prey prey;
    public string Location { get; private set; }
    public string Date { get; private set; }
    public Prey Prey => prey;

    public Trophy(string location, string date, Prey prey)
    {
        Location = location;
        Date = date;
        this.prey = prey;
    }
}
namespace Vaccination;

public class Shot
{
    private Vaccine vaccine;
    private int date;

    public Shot(Vaccine vaccine, int date)
    {
        this.vaccine = vaccine;
        this.date = date;
    }
}
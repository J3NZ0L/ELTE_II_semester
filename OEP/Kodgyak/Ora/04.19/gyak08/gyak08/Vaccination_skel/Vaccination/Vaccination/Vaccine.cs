namespace Vaccination;

public abstract class Vaccine
{
    private int expirationDate;

    protected Vaccine(int expirationDate)
    {
        this.expirationDate = expirationDate;
    }
    
    public virtual string Name { get; }
    public virtual int Repeat { get; }
}
namespace Hunter;

public abstract class Prey
{
    private double weight;
    public double Weight => weight;

    private Sex sex;
    public Sex Sex => sex;

    protected Prey(double weight, Sex sex)
    {
        this.weight = weight;
        this.sex = sex;
    }

    public virtual bool IsElephant() => false;
    public virtual bool IsLion() => false;
    public virtual bool IsRhinoceros() => false;
}
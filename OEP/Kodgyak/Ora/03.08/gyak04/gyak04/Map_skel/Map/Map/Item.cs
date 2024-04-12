namespace Map;

public class Item //lehetne struct is
{
    public int Key { get; init; }
    //public required int Key { get; init; }
    public string Data { get; init; }

    public override string ToString() => $"({Key}: \"{Data}\")";
}
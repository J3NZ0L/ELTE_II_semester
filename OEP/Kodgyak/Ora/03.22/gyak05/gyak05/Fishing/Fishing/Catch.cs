using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record Catch
{
    public string Time { get; init; }
    public string Species { get; init; }
    public int Length { get; init; }
    public int Weight { get; init; }

    public Catch() { }
    public Catch(string time, string species, int length, int weight)
    {
        Time = time; 
        Species = species;
        Length = length;
        Weight = weight;
    }
}

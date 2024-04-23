using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bag;

public class Bag
{
    private class Pair
    {
        public required string Data { get; set; }
        public required int Count { get; set; }

        public override string ToString()
        {
            return $"(\"{Data}\": {Count})";
        }
    }

    private List<Pair> seq;
    private int maxind;

    public Bag()
    {
        // TODO
    }

    public bool Empty() => seq.Count == 0;

    public Func<string, int> Multipl => Multiplicity; // yes, this is possible
    public int Multiplicity(string s)
    {
        // TODO
    }

    public string? Max() => seq.Count > 0 ? seq[maxind].Data : null;

    public void SetEmpty()
    {
        // TODO
    }

    public void Insert(string s)
    {
        (bool b, int ind) = LogSearch(s);
        
        if (b)
        {
            ++seq[ind].Count;
            if (seq[ind].Count > seq[maxind].Count) maxind = ind;
        }
        else
        {
            seq.Insert(ind, new Pair { Data = s, Count = 1 });
            if (seq.Count == 1) maxind = 0;
            else if (maxind > ind) ++maxind;
        }
    }

    public void Remove(string s)
    {
        (bool b, int ind) = LogSearch(s);

        if (b)
        {
            if (seq[ind].Count > 1) --seq[ind].Count;
            else if (seq[ind].Count == 1) seq.RemoveAt(ind); // !!!

            if (Empty()) maxind = -1;
            else
            {
                // MAX search
                // TODO
            }
        }
    }
    
    private (bool, int) LogSearch(string s)
    {
        if (Empty()) return (false, 0);
        (bool b, int lb, int ub) = (false, 0, seq.Count - 1);
        int ind = 0;
        while (lb <= ub)
        {
            ind = (lb + ub) / 2;
            if (seq[ind].Data == s)
            {
                b = true;
                lb = ind;
                break;
            }
            if (string.Compare(seq[ind].Data, s) < 0)
            {
                lb = ind + 1;
            }
            else
            {
                ub = ind - 1;
            }
        }

        return (b, lb);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder("{");
        foreach (var p in seq)
        {
            sb.Append($"{p}, ");
        }

        if(!Empty()) sb.Remove(sb.Length - 2, 2); // remove the last ', ' pair
        sb.Append("}");
        return sb.ToString();
    }
}
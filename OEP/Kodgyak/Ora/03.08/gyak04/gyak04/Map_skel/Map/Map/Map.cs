using System;
using System.Collections.Generic;
using System.Text;

namespace Map;

public class Map : Map
{
    private List<Item> seq;

    public Map()
    {
        seq = new();
    }
    
    public void SetEmpty()
    {
        seq.Clear();
        // seq = new(); also works but not very efficient with memory 
    }

    public int Count => seq.Count;
    //public int Count{ get { return seq.Count;}} re shorthand

    public void Insert(int key, string item)
    {
        (bool b, int ind) = LogSearch(key);
        if (b) throw new ArgumentException($"There is an element in the map with the specified key!");
        seq.Insert(ind, new Item{Key = key, Data = item});
    }

    public void Remove(int key)
    {
        (bool b, int ind) = LogSearch(key);
        if (!b) throw new KeyNotFoundException($"Key does not exist in the map!");
        seq.RemoveAt(ind);
    }

    public bool In(int key)
    {
        return LogSearch(key).Item1;
    }
    // indexer
    public string this[int key]
    {
        get
        {
            (bool b, int ind) = LogSearch(key);
            if (!b) throw new KeyNotFoundException("KEy not found!");
            return seq[ind].Data;
        }
        set
        {
            (bool b, int ind) = LogSearch(key);
            if (b) throw new ArgumentException("there is ane element");
            seq.Insert(ind, new Item { Key = key, Data = value });
        }
    }

    

    private (bool, int) LogSearch(int key)
    {
        bool b = false;
        int lb = 0;
        int ub = 0;
        while (lb <= ub)
        {
            int ind = (lb + ub) / 2;
            if (seq[ind].Key == key)
            {
                b = true;
                lb = ind;
                break;
            }
            if (seq[ind].Key > key) ub = ind - 1;
            else lb = ind + 1;
         }
        return (b, lb);
    }

    public override string ToString()
    {
        // TODO
        // return "{" + string.Join(", ", seq.Select( e => e.ToString())) + "
        StringBuilder sb = new StringBuilder("{");
        foreach ( Item it in seq )
        {
            sb.Append(it.ToString()+ ", ");
        }
        if (seq.Count !=0) sb.Remove(sb.Length - 2, 2);
        return sb.ToString();
    }
}
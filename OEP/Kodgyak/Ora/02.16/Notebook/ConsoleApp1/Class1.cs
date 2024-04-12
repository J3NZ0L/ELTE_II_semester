using System;
using System.Collections.Generic;
using System.Linq;

namespace Notebook;

public class Notebook
{
    public class InvalidPageException : Exception
    {
        public InvalidPageException() : base() { }
        public InvalidPageException(string message) : base(message) { }
        public InvalidPageException(string message, Exception innerException) : base(message, innerException) { }
    }

    public enum Sort
    {
        Plain,
        Grid,
        Lined,
    }

    private readonly Sort sort; // típus
    private readonly List<string> pages; // lapok
    private int empty; // üres

    public Sort NotebookSort { get => sort; }

    // indexers
    public string this[int idx]
    {
        get
        {
            --idx;
            if (idx < 0 || idx >= pages.Count)
                throw new InvalidPageException($"Page {idx + 1} does not exist.");
            return pages[idx];
        }
    }

    public Notebook(int n, Sort srt) // Spiral
    {
        //pages = new List<string>(N);
        //for (int i = 0; i < n; ++i) pages.Add("");
        pages = Enumerable.Repeat("", n).ToList(); //shallow copy but  we overw
        sort = srt;
        empty = n;
    }

    public int EmptyCount() // ÜresDB
    {
        return empty;
    }

    public int PageCount() // LapDB
    {
        return pages.Count;
    }

    public void WriteOnPage(int ind, string content) // Ráír
    {
        --ind;
        if (ind < 0 || ind >= pages.Count)
            throw new InvalidPageException($"{ind + 1} is not a valid page number.");
        if (pages[ind] != "")
            throw new InvalidPageException($"Page {ind + 1} is full.");

        pages[ind] = content;
        empty -= 1;

    }

    public void TearOut(int ind) // Kitép
    {
        --ind;
        if (ind < 0 || ind >= pages.Count)
            throw new InvalidPageException($"{ind + 1} is not a valid page number.");

        if (pages[ind] == "")
        {
            empty -= 1;
        }
        pages.RemoveAt(ind);
    }

    // this is a ValueTuple under the hood
    public (bool found, int ind) Search() // Keres
    {
        bool b = false;
            for (int i = 0; i < pages.Count; i++)
            {
                if (pages[i] == "")
                {
                    return (true, i + 1);
                }
            }
        return (false, -1);
    }
}
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

    public Notebook(int n, Sort srt) // Spirál
    {
        // TODO
    }

    public int EmptyCount() // ÜresDB
    {
        // TODO
    }

    public int PageCount() // LapDB
    {
        // TODO
    }
    
    public void WriteOnPage(int ind, string content) // Ráír
    {
        --ind;
        if (ind < 0 || ind >= pages.Count) 
            throw new InvalidPageException($"{ind + 1} is not a valid page number.");
        if (pages[ind] != "")
            throw new InvalidPageException($"Page {ind + 1} is full.");

        // TODO
    }

    public void TearOut(int ind) // Kitép
    {
        --ind;
        if (ind < 0 || ind >= pages.Count) 
            throw new InvalidPageException($"{ind + 1} is not a valid page number.");
        
        // TODO
    }

    // this is a ValueTuple under the hood
    public (bool found, int ind) Search() // Keres
    {
        // TODO
    }
}
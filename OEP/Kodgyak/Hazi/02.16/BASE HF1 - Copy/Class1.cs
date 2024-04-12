using System;
using System.Collections.Generic;
using System.Linq;

namespace HF1;

public class Labirynth
{
    public class InvalidDirectionException : Exception
    {
        public InvalidDirectionException() : base() { }
        public InvalidDirectionException(string message) : base(message) { }        
    }
    public class InvalidCollectRequestException : Exception
    {
        public InvalidCollectRequestException() : base() { }
        public InvalidCollectRequestException(string message) : base(message) { }
    }
    public enum Content
    {
        EMPTY,
        WALL,
        TREASURE,
        GHOST,
    }
    public record Direction
    {
        public int x, y;
    }
    private Content[,] Map;
    public Labirynth(Content[,] tartalommatrix)
    {
        Map = tartalommatrix; 
    }
    public Content WhatIsThere(int x, int y, Direction ir)
    {
        
        if (!((x + ir.x) >= 0 && (x + ir.x) <= Map.GetLength(0)-1 && (y + ir.y) >= 0 && (y + ir.y) <= Map.GetLength(1)-1) || (ir.x == 0 && ir.y == 0))
        {
            throw new InvalidDirectionException("Invalid direction");
        }
        else
        {
            
            return Map[x + ir.x, y + ir.y];
        }
    }

    public void Collect(int x, int y)
    {
        if (Map[x, y] != Content.TREASURE)
        {
            throw new InvalidCollectRequestException("Location does not contain a treasure");
        } 
        Map[x,y]= Content.EMPTY;
    }
}



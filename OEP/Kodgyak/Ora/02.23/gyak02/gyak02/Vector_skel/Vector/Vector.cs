using System;

namespace Vector;

public class Vector
{
    private double x;
    private double y;

    // TODO getters
	
    // TODO length

    public Vector() : this(0, 0) { }

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        // TODO
    }

    // TODO operator*
}
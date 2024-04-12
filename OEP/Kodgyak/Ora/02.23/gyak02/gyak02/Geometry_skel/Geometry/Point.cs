using System;

namespace Geometry;

public class Point
{
    private double x;
    private double y;

    //ctor / ctorf 
    public Point(double a, double b)
    {
        x = a;
        y = b;
    }

    public double Distance(Point p)
    {
        return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
    }
}
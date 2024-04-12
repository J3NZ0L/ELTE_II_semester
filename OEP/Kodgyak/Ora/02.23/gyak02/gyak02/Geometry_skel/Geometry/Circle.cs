using System;

namespace Geometry;

public class Circle
{
    public class IllegalRadiusException : Exception
    {
        public IllegalRadiusException() { }
        public IllegalRadiusException(string message) : base(message) { }
        public IllegalRadiusException(string message, Exception innerException) : base(message, innerException) { }
    }

    // kell: ktor + tartalmaz
    // Tartalmaz -> Contains
    private Point c;
    private double r;

    public Circle(Point c, double r)
    {
        if (r < 0) throw new IllegalRadiusException("whatever");
        this.c = c;
        this.r = r;
    }
    public bool Contains(Point p) => c.Distance(c <= r);
}
using System;
using System.Text.RegularExpressions;

namespace Complex;

public class Complex
{
    private readonly double x;
    private readonly double y;

    public Complex(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    // readonly x, y
    // ctorf

    public static Complex operator +(Complex a, Complex b) {  //operator feluldefinialas kulccsava az operator!! eza szintaktikaja
        return new Complex( a.x+b.x, a.y+b.y );
    }  //Osztalyszintu metodus kulcsszava a static!!

    public static Complex operator -(Complex a, Complex b)
    {  //operator feluldefinialas kulccsava az operator!! eza szintaktikaja
        return new Complex(a.x - b.x, a.y - b.y);
    }  //Osztalyszintu metodus kulcsszava a static!!

    public static Complex operator *(Complex a, Complex b)
    {  //operator feluldefinialas kulccsava az operator!! eza szintaktikaja
        return new Complex(a.x * b.x - a.y *b.y, a.x + b.y+a.y*b.x);
    }  //Osztalyszintu metodus kulcsszava a static!!

    public static Complex operator /(Complex a, Complex b)
    {  //operator feluldefinialas kulccsava az operator!! eza szintaktikaja
        if (Math.Abs(b.x) > double.Epsilon * 16 && Math.Abs(b.y) < double.Epsilon)
        {
            throw new DivideByZeroException("division by 0+0i");
        }
        return new Complex((a.x * b.x + a.y * b.y) / (b.x * b.x + b.y*b.y), (a.y * b.x - a.x * b.y) / (b.x* b.y + b.y *b.y));
    }  //Osztalyszintu metodus kulcsszava a static!!

    public override string ToString() //feluldefinialas
    {
        return $"{x} {(y< 0 ? '-' : '+')} {Math.Abs(y)}i";
    }



    public static Complex Parse(string str)
    {
        const string rex = @"^\s*(?<a>\d+(?:\.\d*)?)\s*(?<s>[+-])\s*(?<b>\d+(?:\.\d*)?)\s*\*?\s*i\s*$";
        Regex parse = new Regex(rex);
        
        Match m = parse.Match(str);
        double a, b;
        
        try
        {
            a = double.Parse(m.Groups["a"].Value);
            b = double.Parse(m.Groups["b"].Value);
			if (m.Groups["s"].Value == "-") b = -b;
        }
        catch(Exception ex)
        {
            throw new FormatException("Complex number had invalid format.", ex);
        }

        return new Complex(a, b);
    }
    
    // ToString
}
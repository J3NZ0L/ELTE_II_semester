using System.Text;

namespace LowerTriangleMatrix;

public class LTM
{
    private double[] x;
    private int dim;
    
    public LTM(int n)
    {
        dim = n;
        x = new double[(dim * (dim + 1)) / 2];
    }
    
    // matrices are indexed from 1 by convention
    public double this[int i, int j]
    {
        get
        {
            if (i < 1 || i > dim || j < 1 || j > dim)
                throw new IndexOutOfRangeException("Trying to index out of the matrix");
            return i >= j ? x[Ind(i, j)] : 0.0;
        }
        set
        {
            if (i < 1 || i > dim || j < 1 || j > dim)
                throw new IndexOutOfRangeException("Trying to index out of the matrix");
            if (i < j && value != 0.0) 
                throw new ThisIsALeftTriangleMatrixException("Upper triangle must have zeros");
            if (i >= j)
                x[Ind(i, j)] = value;
        }
    }

    public static LTM operator +(LTM a, LTM b)
    {
        if (a.dim != b.dim) throw new ArgumentException("You may only add matrices of the same size");
        LTM c = new LTM(a.dim);

        for (int i=0;i<a.x.Length; ++i)
        {
            c.x[i] = a.x[i] + b.x[i];
        }

        return c;
    }

    public static LTM operator *(LTM a, LTM b)
    {
        if (a.dim != b.dim) throw new ArgumentException("You may only multiply matrices of the same size");
        LTM c = new LTM(a.dim);

        for (int i=1;i<=a.dim; ++i)
        {
            for (int j=1; j<=i; ++j)
            {
                c[i, j] = 0.0;
                for (int k=j; k<=i; ++k)
                {
                    //c[i, j] += c[i, k] + b[k, j];
                    c.x[Ind(i, j)] += a.x[Ind(i, k)] * b.x[Ind(k, j)];
                }
            }
        }

        return c;
    }
    
    private static int Ind(int i, int j) => i * (i - 1) / 2 + j - 1;

    public override string ToString()
    {
        int blockLength = x.Max((double d) => d.ToString().Length) + 1;
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= dim; ++i)
        {
            sb.Append("( ");
            for (int j = 1; j <= dim; ++j)
            {
                sb.Append(this[i, j].ToString().PadRight(blockLength, ' '));
            }
            sb.Append(" )\n");
        }

        return sb.ToString();
    }
}
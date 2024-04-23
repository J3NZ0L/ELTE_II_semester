namespace LowerTriangleMatrix;

public class ThisIsALeftTriangleMatrixException : Exception
{
    public ThisIsALeftTriangleMatrixException() { }

    public ThisIsALeftTriangleMatrixException(string message) : base(message) { }
    
    public ThisIsALeftTriangleMatrixException(string message, Exception innerException) : base(message) { }
}
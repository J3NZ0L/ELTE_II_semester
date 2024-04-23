namespace LowerTriangleMatrix;

public class Menu
{
    private const int DEFAULT_SIZE = 3;
    private const int DEFAULT_MCOUNT = 2;

    private readonly LTM[] matrices;
    private readonly int size;
    private readonly int mcount;

    public Menu(int size = DEFAULT_SIZE, int mcount = DEFAULT_MCOUNT)
    {
        this.size = size;
        this.mcount = mcount;
        matrices = new LTM[mcount];

        for (int i = 0; i < mcount; ++i)
        {
            matrices[i] = new LTM(size);
        }
    }

    public void Run()
    {
        int n;
        do
        {
            do
            {
                PrintMenu();
            } while (!int.TryParse(Console.ReadLine(), out n));

            switch (n)
            {
                case 1:
                    GetElement();
                    break;
                case 2:
                    SetElement();
                    break;
                case 3:
                    PrintMatrix();
                    break;
                case 4:
                    AddMatrices();
                    break;
                case 5:
                    MultMatrices();
                    break;
            }
        } while (n != 0);
    }

    private void PrintMenu()
    {
        Console.WriteLine("\n\n 0. - Quit");
        Console.WriteLine(" 1. - Get an element of a matrix");
        Console.WriteLine(" 2. - Overwrite an element of a matrix");
        Console.WriteLine(" 3. - Print matrix");
        Console.WriteLine(" 4. - Add matrices");
        Console.WriteLine(" 5. - Multiply matrices");
        Console.WriteLine($"There are {mcount} matrices with a dimension of {size}.\n" +
                          $"Remember: matrix indices start from 1.");
        Console.Write("> ");
    }

    private void GetElement()
    {
        int id = GetMatrixId();
        (int i, int j) = GetPosition();
        Console.WriteLine($"Element at position ({i},{j}) is {matrices[id][i, j]}");
    }

    private void SetElement()
    {
        int id = GetMatrixId();
        (int i, int j) = GetPosition();
        double value;
        do
        {
            Console.Write("Value: ");
        } while (!double.TryParse(Console.ReadLine(), out value));
        Console.WriteLine($"Setting {value} to position ({i},{j})");
        matrices[id][i, j] = value;
    }

    private void PrintMatrix()
    {
        int id = GetMatrixId();
        Console.WriteLine($"Matrix {id} starts below:");
        Console.WriteLine(matrices[id]);
    }

    private void AddMatrices()
    {
        Console.WriteLine("C := A + B");
        Console.WriteLine("A:");
        int a = GetMatrixId();
        Console.WriteLine("B:");
        int b = GetMatrixId();
        Console.WriteLine("C:");
        int c = GetMatrixId();

        matrices[c] = matrices[a] + matrices[b];
    }

    private void MultMatrices()
    {
        Console.WriteLine("C := A * B");
        Console.WriteLine("A:");
        int a = GetMatrixId();
        Console.WriteLine("B:");
        int b = GetMatrixId();
        Console.WriteLine("C:");
        int c = GetMatrixId();

        matrices[c] = matrices[a] * matrices[b];
    }

    private int GetMatrixId()
    {
        while (true)
        {
            Console.Write("Matrix number (indices start from 0): ");
            if (int.TryParse(Console.ReadLine(), out int id) && 0 <= id && id < mcount)
            {
                return id;
            }    
        }
    }

    private (int i, int j) GetPosition()
    {
        int i, j;
        do
        {
            Console.Write("Row: ");
        } while (!(int.TryParse(Console.ReadLine(), out i) && 1 <= i && i <= size));
        do
        {
            Console.Write("Column: ");
        } while (!(int.TryParse(Console.ReadLine(), out j) && 1 <= j && j <= size));

        return (i, j);
    }
}
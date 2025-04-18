namespace MatrixThread;

public class Matrix
{
    public int Rows { get; private set; }
    public int Columns { get; private set; }

    private int[,] matrix;

    public Matrix(int rows, int columns)
    {
        this.Rows = rows;
        this.Columns = columns;
        matrix = new int[rows, columns];
    }

    public void SetMatrix(int row, int column, int value)
    {
        matrix[row, column] = value;
    }

    public int GetMatrix(int row, int column)
    {
        return matrix[row, column];
    }

    public override string ToString()
    {
        string result = "";
        result += "[\n";
        for (int row = 0; row < Rows; row++)
        {
            result += "  [ ";
            for (int column = 0; column < Columns; column++)
            {
                result += matrix[row, column] + " ";
            }
            result += "]\n";
        }
        result += "]";
        return result;
    }
}
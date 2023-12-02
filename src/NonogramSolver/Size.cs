namespace NonogramSolver;

/// <summary>
/// Represents the size of a grid or matrix with a specified number of rows and columns.
/// </summary>
public struct Size(int rows, int cols)
{
    public int rows = rows;
    public int cols = cols;

    public static implicit operator Size((int rows, int cols) size)
        => new(size.rows, size.cols);

    public static implicit operator (int rows, int cols)(Size size)
        => (size.rows, size.cols);
}
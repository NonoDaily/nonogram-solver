namespace NonogramSolver;

public static class MatrixExtension
{
    /// <summary>
    /// Transposes a matrix.
    /// </summary>
    /// <typeparam name="T">The type of the matrix elements.</typeparam>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transposed matrix.</returns>
    public static T[][] Transpose<T>(this T[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        var transposed = new T[cols][];

        for (int i = 0; i < cols; i++)
        {
            transposed[i] = new T[rows];
            for (int j = 0; j < rows; j++)
                transposed[i][j] = matrix[j][i];
        }

        return transposed;
    }

    /// <summary>
    /// Merges two matrices element-wise using the logical OR operation.
    /// </summary>
    /// <param name="matrix">The first matrix.</param>
    /// <param name="other">The second matrix.</param>
    /// <returns>The merged matrix.</returns>
    public static bool[][] Merge(this bool[][] matrix, bool[][] other)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        var merged = new bool[rows][];

        for (int i = 0; i < rows; i++)
        {
            merged[i] = new bool[cols];
            for (int j = 0; j < cols; j++)
                merged[i][j] = matrix[i][j] | other[i][j];
        }

        return merged;
    }
}
namespace NonogramSolver;

public static class ArrayExtension
{
    public static int AddRange<T>(this T[] values, T item, int start, int count)
    {
        for (int i = 0; i < count; i++)
            values[start++] = item;

        return start;
    }

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
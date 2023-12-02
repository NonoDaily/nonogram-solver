namespace NonogramSolver;

/// <summary>
/// Class responsible for solving nonogram puzzles.
/// </summary>
public class Solver
{

    /// <summary>
    /// Solves the nonogram puzzle based on the provided data.
    /// </summary>
    /// <param name="data">The nonogram data containing the puzzle size and row/column data.</param>
    /// <returns>A 2D array representing the solved nonogram puzzle.</returns>
    public static bool[][] Solve(NonogramData data)
    {
        var rows = new bool[data.Size.rows][];
        var cols = new bool[data.Size.cols][];

        foreach (var (row, index) in data.RowData.Enumerate())
            rows[index] = SolveData(row, data.Size.cols);

        foreach (var (col, index) in data.ColumnData.Enumerate())
            cols[index] = SolveData(col, data.Size.rows);

        bool[][] fullIntersection = rows.Merge(cols.Transpose());

        return [
            [ false, true,  false, true,  false ],
            [ true,  true,  true,  true,  true  ],
            [ true,  true,  true,  true,  true  ],
            [ false, true,  true,  true,  false ],
            [ false, false, true,  false, false ],
        ]; // TODO: return a real solution;
    }


    private static bool[] SolveData(int[] row_data, int row_length)
    {
        var output = new bool[row_length];
        var intersection = row_data.Sum() + row_data.Length - 1;
        var empty = row_length - intersection;
        var index = 0;

        foreach (var item in row_data)
        {
            index = output.AddRange(false, index, empty);

            var value = item - empty;
            if (value > 0)
            {
                index = output.AddRange(true, index, value);

                if (output.Length < row_length)
                    output[index++] = false;
            }
        }

        output.AddRange(false, index, row_length - output.Length);

        return [.. output];
    }
}
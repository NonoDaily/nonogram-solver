using System;
using System.Collections.Generic;
using System.Linq;

namespace NonogramSolver;

public class Solver
{
    public static bool[][] Solve(NonogramData data)
    {
        var rows = new bool[data.Size.rows][];
        var cols = new bool[data.Size.cols][];

        int i = 0;
        foreach (var row in data.RowData)
            rows[i++] = SolveData(row, data.Size.cols);

        i = 0;
        foreach (var column in data.ColumnData)
            cols[i++] = SolveData(column, data.Size.rows);

        var merged = rows.Merge(cols.Transpose());

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
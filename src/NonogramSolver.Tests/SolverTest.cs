namespace NonogramSolver.Tests;

public class SolverTest
{
    [Fact]
    public void SimpleSolver()
    {
        int[][] row_data = [
            [ 1, 1 ],
            [ 5 ],
            [ 5 ],
            [ 3 ],
            [ 1 ],
        ];
        int[][] column_data = [
            [ 2 ],
            [ 4 ],
            [ 4 ],
            [ 4 ],
            [ 2 ]
        ];

        var size = (5, 5);

        NonogramData data = new(row_data, column_data, size);

        bool[][] solve = Solver.Solve(data);

        bool[][] heart = [
            [ false, true,  false, true,  false ],
            [ true,  true,  true,  true,  true  ],
            [ true,  true,  true,  true,  true  ],
            [ false, true,  true,  true,  false ],
            [ false, false, true,  false, false ],
        ];

        Assert.Equal(heart, solve);
    }
}
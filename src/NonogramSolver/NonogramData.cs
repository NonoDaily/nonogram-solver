namespace NonogramSolver;

/// <summary>
/// Represents the data for a nonogram puzzle, including the row and column data and the size of the puzzle.
/// </summary>
public record NonogramData(int[][] RowData, int[][] ColumnData, Size Size);

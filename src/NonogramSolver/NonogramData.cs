namespace NonogramSolver;

public record NonogramData(int[][] RowData, int[][] ColumnData, (int rows, int cols) Size);
namespace NonogramSolver;

public static class ArrayExtension
{
    /// <summary>
    /// Sums all the values in an array.
    /// </summary>
    /// <param name="source">Source array to be sum up</param>
    /// <returns>The sum of all elements</returns>
    public static int Sum(this int[] source)
    {
        int sum = 0;

        foreach (var value in source)
            sum += value;

        return sum;
    }

    /// <summary>
    /// Enumerates an array with its index.
    /// </summary>
    /// <typeparam name="T">The type of the array elements</typeparam>
    /// <param name="source">The source array to be enumerated</param>
    /// <returns>An array of tuples containing the value and index of each element</returns>
    public static (T Value, int Index)[] Enumerate<T>(this T[] source)
    {
        var result = new (T, int)[source.Length];

        for (int i = 0; i < source.Length; i++)
            result[i] = (source[i], i);

        return result;
    }

    /// <summary>
    /// Adds a range of items to an array.
    /// </summary>
    /// <typeparam name="T">The type of the array elements</typeparam>
    /// <param name="source">The source array to add items to</param>
    /// <param name="item">The item to be added</param>
    /// <param name="start">The starting index to add the items</param>
    /// <param name="count">The number of items to add</param>
    /// <returns>The index after adding the items</returns>
    public static int AddRange<T>(this T[] source, T item, int start, int count)
    {
        for (int i = 0; i < count; i++)
            source[start++] = item;

        return start;
    }
}
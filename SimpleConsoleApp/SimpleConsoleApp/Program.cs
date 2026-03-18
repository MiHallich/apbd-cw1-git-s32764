// See https://aka.ms/new-console-template for more information

Console.WriteLine("Main branch version");

Console.WriteLine("Average feature");

Console.WriteLine("Feature max branch");

Console.WriteLine("Main branch change");

Console.WriteLine("main change");
Console.WriteLine("Min step 1");

Console.WriteLine("Min step 2");

public static class StatisticsHelper
{
    public static int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        return numbers.Sum();
    }

    public static double Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        return numbers.Average();
    }
    public static int Min(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        return numbers.Min();
    }

    public static int Max(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        return numbers.Max();
    }
    
    public static double Median(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        var sorted = numbers.OrderBy(n => n).ToArray();
        int middle = sorted.Length / 2;

        if (sorted.Length % 2 == 0)
            return (sorted[middle - 1] + sorted[middle]) / 2.0;

        return sorted[middle];
    }

    
}
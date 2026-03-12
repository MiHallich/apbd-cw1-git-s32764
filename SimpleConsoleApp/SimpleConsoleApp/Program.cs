// See https://aka.ms/new-console-template for more information

Console.WriteLine("simple console app");

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
    

    
}
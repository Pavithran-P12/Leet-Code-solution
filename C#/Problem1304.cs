using System;

public class Solution
{
    /// <summary>
    /// Generates an array of n unique integers that sum to zero.
    /// </summary>
    /// <param name="n">The number of integers to generate</param>
    /// <returns>An array of n unique integers whose sum is zero</returns>
    public int[] SumZero(int n)
    {
        int[] result = new int[n];

        // Fill the array with symmetric pairs: [-1, 1], [-2, 2], ...
        for (int i = 0; i < n / 2; i++)
        {
            result[i] = -(i + 1);               // Negative half
            result[n - 1 - i] = (i + 1);         // Positive half
        }

        // If n is odd, set the middle element to 0
        if (n % 2 != 0)
        {
            result[n / 2] = 0;
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        // Example input
        int n = 5;

        // Generate the array
        int[] zeroSumArray = solution.SumZero(n);

        // Print the result
        Console.WriteLine("Zero-sum array:");
        Console.WriteLine(string.Join(", ", zeroSumArray));
    }
}

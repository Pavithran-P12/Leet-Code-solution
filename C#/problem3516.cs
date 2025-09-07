using System;

public class Solution
{
    /// <summary>
    /// Determines which person reaches Person 3 first on a number line.
    /// </summary>
    /// <param name="x">Position of Person 1</param>
    /// <param name="y">Position of Person 2</param>
    /// <param name="z">Position of Person 3 (stationary)</param>
    /// <returns>
    /// 1 if Person 1 arrives first,
    /// 2 if Person 2 arrives first,
    /// 0 if both arrive at the same time.
    /// </returns>
    public int FindClosest(int x, int y, int z)
    {
        // Calculate the absolute distance from each person to Person 3
        int distance1 = Math.Abs(x - z);
        int distance2 = Math.Abs(y - z);

        // Compare distances and return the result
        if (distance1 < distance2)
            return 1; // Person 1 is closer
        else if (distance2 < distance1)
            return 2; // Person 2 is closer
        else
            return 0; // Both are equidistant
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Solution class
        Solution solution = new Solution();

        // Example input: positions of Person 1, Person 2, and Person 3
        int x = 3;
        int y = 7;
        int z = 5;

        // Call the method and print the result
        int result = solution.FindClosest(x, y, z);
        Console.WriteLine("Closest person: " + result);
    }
}

 

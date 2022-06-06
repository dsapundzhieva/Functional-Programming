using System;
using System.Collections.Generic;
using System.Linq;

internal class CustomMinFunction
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        Func<List<int>, int> smallestNumber = nums => nums.Min();

        Console.WriteLine(smallestNumber(nums));
    }
}

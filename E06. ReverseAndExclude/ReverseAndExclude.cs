using System;
using System.Collections.Generic;
using System.Linq;

internal class ReverseAndExclude
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(" ").Select(int.Parse).Reverse().ToList();

        int n = int.Parse(Console.ReadLine());

        Func<List<int>, int, List<int>> excludedNums = (numbers, x) => numbers.Where(number => number % x != 0).ToList();

        Console.WriteLine(string.Join(" ", excludedNums(nums, n)));
      
    }
}

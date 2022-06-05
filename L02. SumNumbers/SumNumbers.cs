using System;
using System.Collections.Generic;
using System.Linq;

internal class SumNumbers
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        Console.WriteLine(input.Length);
        Console.WriteLine(input.Sum());
    }
}

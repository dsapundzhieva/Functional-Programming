using System;
using System.Collections.Generic;
using System.Linq;

internal class SortEvenNumbers
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();

        Console.WriteLine(string.Join(", ",input.Where(x => x % 2 ==0).OrderBy(x => x)));        
    }
}

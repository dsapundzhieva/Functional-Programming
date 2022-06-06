using System;
using System.Collections.Generic;
using System.Linq;

internal class FindEvensOrOdds
{
    static void Main(string[] args)
    {
        var boundaries = Console.ReadLine().Split(" ");
        int start = int.Parse(boundaries[0]);
        int end = int.Parse(boundaries[1]);
        string command = Console.ReadLine();

        Predicate<int> predicate = null;
        List<int> nums = new List<int>();

        for (int i = start; i <= end; i++)
        {
            nums.Add(i);
        }

        if (command == "odd")
        {
            predicate = x => x % 2 != 0;
        }
        else if (command == "even")
        {
            predicate = x => x % 2 == 0;
        }

        Console.WriteLine(string.Join(" ", nums.FindAll(predicate)));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        string command;

        Func<List<int>, List<int>> modified = null;
        Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

        while ((command = Console.ReadLine()) != "end")
        {
            if (command == "add")
            {
                modified = nums => nums.Select(x => x += 1).ToList();
                nums = modified(nums);
            }
            else if (command == "multiply")
            {
                modified = nums => nums.Select(x => x *= 2).ToList();
                nums = modified(nums);
            }
            else if (command == "subtract")
            {
                modified = nums => nums.Select(x => x -= 1).ToList();
                nums = modified(nums);
            }
            else if (command == "print")
            {
                print(nums);
            }
        }
    }
}

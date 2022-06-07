using System;
using System.Collections.Generic;
using System.Linq;

internal class ListOfPredicates
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        Action<int> predicate = null;

        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        List<int> dividibleList = new List<int>();

        foreach (var number in numbers)
        {
            bool isDividible = true;

            foreach (var divider in dividers)
            {
                Predicate<int> divisible = x => x % divider == 0;

                if (!divisible(number))
                {
                    isDividible = false;
                    break;
                }
            }

            if (isDividible)
            {
                dividibleList.Add(number);
            }
        }

        Console.WriteLine(string.Join(" ", dividibleList));
    }
}

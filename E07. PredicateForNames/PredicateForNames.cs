using System;
using System.Collections.Generic;
using System.Linq;

internal class PredicateForNames
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Action<string, int> predicate = (name, x) =>
        {
            if (name.Length <= x)
            {
                Console.WriteLine(name);
            }
        };

        for (int i = 0; i < names.Count; i++)
        {
            predicate(names[i], n);
        }
    }
}

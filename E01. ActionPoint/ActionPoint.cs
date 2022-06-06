using System;
using System.Collections.Generic;
using System.Linq;

internal class ActionPoint
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ").ToList();

        Action<string> print = x => Console.WriteLine(x);

        input.ForEach(print);   
    }
}

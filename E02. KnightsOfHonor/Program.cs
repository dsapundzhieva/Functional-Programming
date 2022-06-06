using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var names = Console.ReadLine().Split(" ").ToList();

        Action<string> modifiedNames = n => Console.WriteLine("Sir " + n);

        names.ForEach(modifiedNames);
    }
}

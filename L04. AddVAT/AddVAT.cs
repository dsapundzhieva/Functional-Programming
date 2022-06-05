using System;
using System.Collections.Generic;
using System.Linq;

internal class AddVAT
{
    Func<double, double> addVat = x => x * 1.20;
    static void Main(string[] args)
    {
        var numsWithVAT = Console.ReadLine()
            .Split(", ")
            .Select(x => double.Parse(x))
            .Select(x => x * 1.20)
            .ToArray();

        Array.ForEach(numsWithVAT, x => Console.WriteLine($"{x:f2}"));
    }
}

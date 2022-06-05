using System;
using System.Collections.Generic;
using System.Linq;

internal class CountUppercaseWords
{
    static void Main(string[] args)
    {

        Func<string, bool> isFirstLetterCapittal = x => x.Length > 0 && char.IsUpper(x[0]);

        Console.WriteLine(
            string.Join(
                "\r\n",
                Console.ReadLine()
                .Split(" ")
                .Where(isFirstLetterCapittal)
                )
            );
    }
}

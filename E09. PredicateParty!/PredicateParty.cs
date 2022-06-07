using System;
using System.Collections.Generic;
using System.Linq;

internal class PredicateParty
{
    static void Main(string[] args)
    {
        List<string> partyList = Console.ReadLine().Split(" ").ToList();

        string command;
        Predicate<string> predicate = null;

        while ((command = Console.ReadLine()) != "Party!")
        {
            var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var cmdType = cmdArgs[0];
            var firstCriteria = cmdArgs[1];
            var secondCriteria = cmdArgs[2];

            if (firstCriteria == "StartsWith")
            {
                predicate = x => x.StartsWith(secondCriteria);
            }
            else if (firstCriteria == "EndsWith")
            {
                predicate = x => x.EndsWith(secondCriteria);
            }
            else if (firstCriteria == "Length")
            {
                predicate = x => x.Length == int.Parse(secondCriteria);
            }

            if (cmdType == "Remove")
            {
                partyList.RemoveAll(predicate);
            }
            else if (cmdType == "Double")
            {
                for (int i = 0; i < partyList.Count; i++)
                {
                    var person = partyList[i];

                    if (predicate(person))
                    {
                        partyList.Insert(i + 1, person);
                        i++;
                    }
                }
            }
        }
        if (partyList.Count > 0)
        {
            Console.WriteLine(string.Join(", ", partyList) + " are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}

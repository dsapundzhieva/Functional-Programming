using System;
using System.Collections.Generic;
using System.Linq;

internal class ThePartyReservationFilterModule
{
    static void Main(string[] args)
    {
        List<string> partyList = Console.ReadLine().Split(" ").ToList();

        string command;
        Predicate<string> predicate = null;

        while ((command = Console.ReadLine()) != "Print")
        {
            var cmdArgs = command.Split(";");

            string cmdType = cmdArgs[0];
            string filterType = cmdArgs[1];
            string filterParameter = cmdArgs[2];

            if (filterType == "Starts with")
            {
                predicate = x => x.StartsWith(filterParameter);
            }
            else if (filterType == "Ends ith")
            {
                predicate = x => x.EndsWith(filterParameter);

            }
            else if (filterType == "Length")
            {
                predicate = x => x.Length == int.Parse(filterParameter);

            }
            else if (filterType == "Contains")
            {
                predicate = x => x.Contains(filterParameter);
            }

            if (cmdType == "Add filter")
            {
                partyList.RemoveAll(predicate);
            }
            else if (cmdType == "Remove filter")
            {
                for (int i = 0; i < partyList.Count; i++)
                {
                    string person = partyList[i];

                    if (predicate(person))
                    {

                    }
                }
            }
        }


    }
}

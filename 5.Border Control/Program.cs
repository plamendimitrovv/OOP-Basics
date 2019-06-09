using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<IIdentible> society = new List<IIdentible>();
        var input = Console.ReadLine();

        
        while (input != "End")
        {
            
            var inputArgs = input.Split();
            IIdentible currentMember;

            if (inputArgs.Length == 3)
            {
                currentMember = new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]);
            }
            else
            {
                currentMember = new Robot(inputArgs[0], inputArgs[1]);
            }

            society.Add(currentMember);
            input = Console.ReadLine();
        }

        var fakeIds = Console.ReadLine();
        foreach (IIdentible member in society.Where(m => m.Id.EndsWith(fakeIds)))
        {
            Console.WriteLine(member.Id);
        }

    }
}




// Pesho 22 9010101122
//MK-13 558833251

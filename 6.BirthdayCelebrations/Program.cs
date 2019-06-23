using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var birthdayGuys = new List<IBirthable>();

        string inputLine = Console.ReadLine();
       

        while (inputLine != "End")
        {
            var inputArgs = inputLine.Split().ToList();
            string typeOfMember = inputArgs[0];
            

            IBirthable currentMember;

            switch (typeOfMember)
            {
                case "Citizen":
                    currentMember = new Citizen(inputArgs[1], int.Parse(inputArgs[2]), inputArgs[3], inputArgs[4]);
                    birthdayGuys.Add(currentMember);
                    inputArgs.RemoveAt(0);
                    break;

                case "Pet":
                    currentMember = new Pet(inputArgs[1], inputArgs[2]);
                    birthdayGuys.Add(currentMember);
                    inputArgs.RemoveAt(0);
                    break;
                default:
                    break;
            }


            inputLine = Console.ReadLine();
            inputArgs.RemoveAt(0);
        }

        var inputYear = Console.ReadLine();

        var filteredMembers = birthdayGuys.Where(m => m.Birthdate.EndsWith(inputYear)).ToArray();

        foreach (var m in filteredMembers)
        {
            Console.WriteLine(m.Birthdate);
        }

    }
}


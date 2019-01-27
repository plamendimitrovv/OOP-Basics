using System;


public class Program
{
    static void Main(string[] args)
    {
        Family family = new Family();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            string name = input[0];
            int age = int.Parse(input[1]);

            family.AddMember(new Person(name, age)); 
        }


        Person oldestPerson = family.GetOldestMember();

        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}



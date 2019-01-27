using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new Person(name, age);

            people.Add(person);
        }

        var sorted = people.Where(a => a.Age > 30).OrderBy(p => p.Name).ToList();

        foreach (var person in sorted)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

        
    }
}


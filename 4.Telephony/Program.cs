using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();
        string[] sites = Console.ReadLine().Split();

        var smartphone = new Smartphone();

        foreach (var number in numbers)
        {
            Console.WriteLine(smartphone.Calling(number));
        }

        foreach (var site in sites)
        {
            Console.WriteLine(smartphone.Browsing(site));
        }
    }
}


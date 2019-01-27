using System;


public class Program
{
    static void Main(string[] args)
    {

        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();


        Console.WriteLine(DataModifier.CalculateDateDifference(firstDate, secondDate)); 
    }
}


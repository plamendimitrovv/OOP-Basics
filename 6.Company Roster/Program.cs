using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        int peopleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < peopleCount; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);

            if (input.Length > 4)
            {
                var ageOrEmail = input[4];
                if (ageOrEmail.Contains("@"))
                {
                    employee.Email = ageOrEmail;
                }

                else
                {
                    employee.Age = int.Parse(input[4]);
                }
            }

            if (input.Length > 5)
            {
                employee.Age = int.Parse(input[5]);
            }

            employees.Add(employee);


        }

    }

}


 
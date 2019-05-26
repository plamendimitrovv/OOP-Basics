using System;


public class Program
{
    static void Main(string[] args)
    {
        // single student -a name and faculty number. 
        string[] studentInfo = Console.ReadLine().Split();
        string studentFirstName = studentInfo[0];
        string studentLastName = studentInfo[1];
        string facultyNumber = studentInfo[2];

        // single worker - first name, last name, salary and working hours.
        
        string[] workerInfo = Console.ReadLine().Split();
        string workerFirstName = workerInfo[0];
        string workerLastName = workerInfo[1];
        decimal salary = decimal.Parse(workerInfo[2]);
        decimal workingHours = decimal.Parse(workerInfo[3]);

        try
        {
            Student student = new Student(studentFirstName, studentLastName, facultyNumber);
            Worker worker = new Worker(workerFirstName, workerLastName, salary, workingHours);

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {

            Console.WriteLine(ae.Message);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber): base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value.Length < 5 || value.Length > 10 || value.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return $@"First Name: {FirstName}
Last Name: {LastName} 
Faculty number: {FacultyNumber}";
    }
}

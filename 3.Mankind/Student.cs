using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value.Length < 3 || value.Length > 10 || value.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            facultyNumber = value;
        }
    }

}

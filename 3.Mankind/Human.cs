using System;
using System.Collections.Generic;
using System.Text;


public class Human
{
    private string firstName;
    private string lastName;

    public Human(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }

            if (!Char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }

            lastName = value;
        }
    }


    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    //1. Fields
    private string name;
    private int age;

    //2. Constructor
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    //3. Properties

    public virtual string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }



    //4. Methods
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                             this.Name,
                             this.Age));

        return stringBuilder.ToString();
    }


}


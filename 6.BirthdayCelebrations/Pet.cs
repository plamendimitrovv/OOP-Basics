using System;
using System.Collections.Generic;
using System.Text;


public class Pet : IBirthable
{
    public Pet(string name, string birthday)
    {
        Name = name;
        Birthdate = birthday;
    }

    public string Name { get; private set; }
    public string Birthdate { get; set;}
}


﻿using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
    //private string name;
    //private decimal salary;
    //private string position;
    //private string email;
    //private int age ;

    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }


    public Employee(string name, decimal salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
        this.Age = -1;
        this.Email = "n/a";
    }

}


﻿using System;
using System.Collections.Generic;
using System.Text;


   public class Person
    {
        private string name;
        private int age;

    public Person()
    {
        this.Name =  "No name";
        this.age = 1; 
    }

    public Person(int age):this()
    {
        this.Age = age;
    }

    public Person(string name, int age):this()
    {
        this.Name = name;
    }

    public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

    }
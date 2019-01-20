using System;
using System.Collections.Generic;
using System.Text;


    class Person
    {
        private string name;
        private int age;


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
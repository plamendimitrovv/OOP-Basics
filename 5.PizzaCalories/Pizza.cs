using System;
using System.Collections.Generic;
using System.Text;


public class Pizza
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Dough Dough { get; set; } // testo
    public List<Topping> Toppings { get; set; }
}


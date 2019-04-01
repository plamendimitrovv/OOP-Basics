using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;


    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bagOfProducts = new List<Product>();
    }

    public List<Product> BagOfProducts
    {
        get { return bagOfProducts; }
        set { bagOfProducts = value; }
    }


    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            else
            {
                money = value;
            }
        }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            else
            {
                name = value;
            }
        }
    }

    public void Print()
    {
        if (bagOfProducts.Count != 0)
        {
            Console.WriteLine($"{Name} - {string.Join(", ", bagOfProducts)}");
        }
        else
        {
            Console.WriteLine($"{Name} - Nothing bought");
        }
    }
}


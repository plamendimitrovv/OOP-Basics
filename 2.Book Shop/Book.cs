using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    //1. Fields
    private string title;
    private string author;
    private decimal price;


    // 2. Constructor
    public Book(string author, string title, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    
    //3. Properties
    public string Title
    {
        get
        {
            return this.title;
        }

        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public string Author
    {
        get
        {
            return this.author;
        }

        set
        {
            string[] tokens = value.Split();
            // string firstName = tokens[0];
            string secondName = tokens[1];

            bool isDigit = char.IsDigit(secondName[0]);

            if (isDigit)
            {
                throw new ArgumentException("Author not valid!");
            }


            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;

        }

    }

    //4. Methods
    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
  
}


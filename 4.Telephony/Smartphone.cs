using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Smartphone : ICallable, IBrowsable
{
    public Smartphone()
    {
    }

    public string Browsing(string url)
    {
        if (url.Any(c => char.IsDigit(c)))
        {
            return "Invalid URL!";
        }

        else
        {
            return "Browsing: " + url + "!";
        }
    }

    public string Calling(string number)
    {
        if (!number.Any(n => char.IsDigit(n)))
        {
            return "Invalid number!";
        }
        else
        {
            return "Calling... " + number;

        }
    }
}


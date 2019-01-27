using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class DataModifier
{
    
    public static int CalculateDateDifference(string firsDate, string secondDate)
    {
        var difference = DateTime.Parse(firsDate) - DateTime.Parse(secondDate);
        return Math.Abs(difference.Days); 
    }
}


using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private double weekSalary;
    private double workingHoursDay;

    public double WorkingHoursDay
    {
        get { return workingHoursDay; }
        set { workingHoursDay = value; }
    }


    public double WeekSalary
    {
        get { return weekSalary; }
        set { weekSalary = value; }
    }

}


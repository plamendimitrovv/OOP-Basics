using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private decimal weekSalary;
    private decimal workingHoursDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHoursDay)
        : base(firstName, lastName)
    {
        WorkingHoursDay = workingHoursDay;
        WeekSalary = weekSalary;
    }

    public decimal WorkingHoursDay
    {
        get { return workingHoursDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workingHoursDay = value;
        }
    }


    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public decimal SalaryPerHour()
    {
        return (WeekSalary / 5) / WorkingHoursDay;
    }

    public override string ToString()
    {
        return $@"First Name: {FirstName} 
Last Name: {LastName} 
Week Salary: {WeekSalary:F2} 
Hours per day: {WorkingHoursDay:F2}
Salary per hour: {(SalaryPerHour()):F2}";
    }

}


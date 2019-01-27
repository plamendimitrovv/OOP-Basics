using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Family
{

    public List<Person> people;
    private bool isOrdered;

    public Family()
    {
        people = new List<Person>();
        isOrdered = false;    
    }


    public void AddMember(Person member)
    {
        people.Add(member);
        isOrdered = false;

    }

    public Person GetOldestMember()
    {
        if (!isOrdered)
        {
            isOrdered = true;
            return people.OrderByDescending(a => a.Age).FirstOrDefault(); 
        }

        return people[0];
    }

}
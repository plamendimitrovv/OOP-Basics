using System;
using System.Collections.Generic;
using System.Text;


public class Tesla : ICar, IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Batteries { get; private set; }


    public Tesla(string model, string color, int batteries)
    {
        Model = model;
        Color = color;
        Batteries = batteries;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{Color} {Model} with {Batteries} Batteries {Start()} {Stop()}";
    }

}


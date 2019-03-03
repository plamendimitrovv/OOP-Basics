using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model;
    private double power;
    private string displacement;
    private string efficiency;

    public Engine(string model, double power)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = "n/a";
    }

    public string Model { get => model; set => model = value; }
    public double Power { get => power; set => power = value; }
    public string Displacement { get => displacement; set => displacement = value; }
    public string Efficiency { get => efficiency; set => efficiency = value; }
}


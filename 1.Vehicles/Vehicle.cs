using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle : IVehicle
{
    public const string InsufficientFuelErrorMessage = "{0} needs refueling"; 

    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double distanceDriven;
    
    protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.DistanceDriven = 0;
    }

    public double DistanceDriven
    {
        get { return distanceDriven; }
        set { distanceDriven = value; }
    }

    public virtual double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        set { fuelConsumptionPerKm = value; }
    }


    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }
         

    public virtual void Drive(double distance)
    {
        if (FuelQuantity / FuelConsumptionPerKm < distance)
        {
            throw new InvalidOperationException(string.Format(InsufficientFuelErrorMessage, this.GetType().Name));
        }

        FuelQuantity = FuelQuantity - (distance * FuelConsumptionPerKm);
        DistanceDriven = DistanceDriven + distance; 
    }

    public virtual void Refuel(double amount)
    {
        this.FuelQuantity += amount;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}


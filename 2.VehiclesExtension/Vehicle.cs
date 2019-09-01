using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle : IVehicle
{
    public const string InsufficientFuelErrorMessage = "{0} needs refueling";
    public const string FuelAmoungError = "Fuel must be a positive number";
    public const string ExessFuelErrorMessage = "Cannot fit {0} fuel in the tank";
    public const double carACExtraConsumption = 0.9;
    public const double truckACExtraConsumption = 1.6;
    public const double busACExtraConsumption = 1.4;
    public const double FuelLossRatio = 0.95; 

    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double distanceDriven;
    private double tankCapacity;



    protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.DistanceDriven = 0;
        this.TankCapacity = tankCapacity;
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
        get
        {
            return fuelQuantity;
        }

        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException(FuelAmoungError);
            }
            if (value > this.TankCapacity)
            {
                fuelQuantity = 0; 
            }
            else
            {
                fuelQuantity = value;
            }
            
        }
    }

    public double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
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

        if (amount <= 0)
        {
            throw new ArgumentException(FuelAmoungError); 
        }

        else if (FuelQuantity + amount > TankCapacity)
        {
            throw new ArgumentException(string.Format(ExessFuelErrorMessage, amount)); 
        }
        else
        {
            FuelQuantity += amount;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }

}


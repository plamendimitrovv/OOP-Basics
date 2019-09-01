using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
    }

    public override double FuelConsumptionPerKm
    {
        get => base.FuelConsumptionPerKm + truckACExtraConsumption;
    }

    public override void Refuel(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(FuelAmoungError);
        }

        if (FuelQuantity + amount * FuelLossRatio > TankCapacity)
        {
            throw new ArgumentException(string.Format(ExessFuelErrorMessage, amount));
        }

        FuelQuantity += amount * FuelLossRatio; 
    }
}


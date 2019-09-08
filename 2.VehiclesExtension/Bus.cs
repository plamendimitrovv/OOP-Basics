using System;
using System.Collections.Generic;
using System.Text;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {

    }

    public override void Drive(double distance)
    {
        var fuelNeeded = distance * (FuelConsumptionPerKm + busACExtraConsumption);

        if (fuelNeeded > FuelQuantity)
        {
            throw new ArgumentException(string.Format(InsufficientFuelErrorMessage, GetType().Name));
        }

        FuelQuantity -= fuelNeeded;
    }


    public void DriveEmpty(double distance)
    {
        base.Drive(distance);
    }
}


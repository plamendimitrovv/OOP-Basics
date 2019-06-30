using System;


class Program
{
    static void Main(string[] args)
    {
        var carInfo = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

        var truckInfo = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

        var numOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfCommands; i++)
        {
            var commandArgs = Console.ReadLine().Split();
            var command = commandArgs[0];
            var typeOfVehicle = commandArgs[1];
            var paramGiven = double.Parse(commandArgs[2]);

            IVehicle vehicleToOperate;
            if (typeOfVehicle == "Car")
            {
                vehicleToOperate = car;
            }

            else
            {
                vehicleToOperate = truck;
            }

            switch (command)
            {
                case "Drive":
                    try
                    {
                        vehicleToOperate.Drive(paramGiven);
                        Console.WriteLine($"{vehicleToOperate.GetType().Name} travelled {paramGiven} km");
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                    break;

                case "Refuel":
                    vehicleToOperate.Refuel(paramGiven);
                    break;
            }

        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}


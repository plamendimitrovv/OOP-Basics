using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int carsToTrack = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < carsToTrack; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            var modelCar = tokens[0];
           // var fuelAmount = double.Parse(tokens[1]);
           //  var fuelConsumption = double.Parse(tokens[2]);

            if (!cars.Any(c => c.Model == modelCar))
            {
                Car car = new Car(modelCar, double.Parse(tokens[1]), double.Parse(tokens[2]));
                cars.Add(car);
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            string model = tokens[1];
            double distance = double.Parse(tokens[2]);

            Car car = cars.Find(c => c.Model == model);
            bool isMoved = car.Drive(distance);

            if (!isMoved)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        foreach (var c in cars)
        {
            Console.WriteLine($"{c.Model} {c.FuelAmount:F2} {c.Distance}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace P06.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] currCarArgs=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Car currCar = new Car(currCarArgs[0]
                    , double.Parse(currCarArgs[1])
                    , double.Parse(currCarArgs[2])
                    ,0);
                cars.Add(currCar.Model,currCar);
            }

            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                string[] command = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = command[1];
                double distance=double.Parse(command[2]);
                if (cars[model].CanItDrive(distance))
                {
                    cars[model].FuelAmount -= distance * cars[model].FuelConsumptionPerKilometer;
                    cars[model].TravelledDistance += distance;
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}

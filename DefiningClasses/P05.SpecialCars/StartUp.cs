using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            // TODO: define the Main() method here ... 
            List<Car> specialCars=new List<Car>();
            List<Car> allCars=new List<Car>();
            List<Tire[]> specialTires=new List<Tire[]>();
            List<Engine> engines=new List<Engine>();
            string cmd;
            while ((cmd=Console.ReadLine())!="No more tires")
            {
                string[] tires = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] currTires=new Tire[tires.Length/2];
                int tireCount=0;
                for (int i = 0; i < tires.Length; i+=2)
                {
                    int currTiresYear = int.Parse(tires[i]);
                    double currTiresPressure = double.Parse(tires[i + 1]);
                    currTires[tireCount] = new Tire(currTiresYear, currTiresPressure);
                    tireCount++;
                }
                specialTires.Add(currTires);
            }

            string cmd2;
            while ((cmd2 = Console.ReadLine()) !="Engines done")
            {
                string[] currEngine=cmd2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engineToAdd = new Engine(int.Parse(currEngine[0]), double.Parse(currEngine[1]));
                engines.Add(engineToAdd);
            }

            string cmd3;
            while ((cmd3 = Console.ReadLine()) != "Show special")
            {
                //{ make}
                //{ model}
                //{ year}
                //{ fuelQuantity}
                //{ fuelConsumption}
                //{ engineIndex}
                //{ tiresIndex}
                string[] currCar=cmd3.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(currCar[0]
                    , currCar[1]
                    , int.Parse(currCar[2])
                    , double.Parse(currCar[3])
                    , double.Parse(currCar[4])
                    , engines[int.Parse(currCar[5])]
                    , specialTires[int.Parse(currCar[6])]);
                allCars.Add(car);
            }
            
            foreach (var car in allCars.Where(x => x.Year >= 2017)
                         .Where(x => x.Engine.HorsePower > 330)
                         .Where(x => x.Tires.Sum(x => x.Pressure) > 9)
                         .Where(x => x.Tires.Sum(x => x.Pressure) < 10))
            {
                car.Drive(20);
                if (car.FuelQuantity>0)
                {
                    specialCars.Add(car);
                }
                
            }
            
            
            foreach (var specialCar in specialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}

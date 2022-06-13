using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                Car currCar;
                Engine currEngine = new Engine();
                Cargo currCargo=new Cargo();
                Tire[] currTires=new Tire[4];
                string[] cmd=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                //"{model} {engineSpeed} {enginePower}
                //{cargoWeight} {cargoType}
                //{tire1Pressure} {tire1Age}
                //{tire2Pressure} {tire2Age}
                //{tire3Pressure} {tire3Age}
                //{tire4Pressure} {tire4Age}"
                string model=cmd[0];
                currEngine.Speed = int.Parse(cmd[1]);
                currEngine.Power= int.Parse(cmd[2]);
                currCargo.Weight = int.Parse(cmd[3]);
                currCargo.Type = cmd[4];
                currTires = new Tire[]
                {
                    new Tire(int.Parse(cmd[6]), double.Parse(cmd[5])),
                    new Tire(int.Parse(cmd[8]), double.Parse(cmd[7])),
                    new Tire(int.Parse(cmd[10]), double.Parse(cmd[9])), 
                    new Tire(int.Parse(cmd[12]), double.Parse(cmd[11]))
                };
                currCar = new Car(model, currEngine, currCargo, currTires);
                cars.Add(currCar);
            }
            string secondCommand=Console.ReadLine();
            if (secondCommand=="fragile")
            {
                foreach (var car in cars.Where(x=>x.Cargo.Type=="fragile"))
                {
                    if (car.Tires.FirstOrDefault(x => x.Pressure < 1) != null)
                        Console.WriteLine($"{car.Model}");
                }
            }
            else if (secondCommand=="flammable")
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == "flammable"))
                {
                    if (car.Engine.Power>250)
                        Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Engine currEngine = new Engine();
                string currEngineModel=cmd[0];
                currEngine.Model=currEngineModel;
                int currEnginePower = int.Parse(cmd[1]);
                currEngine.Power=currEnginePower;
                if (cmd.Length==4)
                {
                    int currEngineDisplacement=int.Parse(cmd[2]);
                    currEngine.Displacement=currEngineDisplacement;
                    string currEngineEfficiency=cmd[3];
                    currEngine.Efficiency=currEngineEfficiency;
                }
                else if (cmd.Length==3)
                {
                    if (char.IsDigit(cmd[2][0]))
                    {
                        int currEngineDisplacement = int.Parse(cmd[2]);
                        currEngine.Displacement = currEngineDisplacement;
                    }
                    else
                    {
                        string currEngineEfficiency = cmd[2];
                        currEngine.Efficiency = currEngineEfficiency;
                    }
                }
                engines.Add(currEngine);
            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Car currCar = new Car();
                string currCarModel = command[0];
                currCar.Model = currCarModel;
                Engine currCarEngine = engines.FirstOrDefault(x => x.Model == command[1]);
                currCar.Engine=currCarEngine; 
                if (command.Length == 4)
                {
                    int currCarWeight = int.Parse(command[2]);
                    currCar.Weight = currCarWeight;
                    string currCarColor = command[3];
                    currCar.Color = currCarColor;
                }
                else if (command.Length==3)
                {
                    if (char.IsDigit(command[2][0]))
                    {
                        int currCarWeight = int.Parse(command[2]);
                        currCar.Weight = currCarWeight;
                    }
                    else
                    {
                        string currCarColor = command[2];
                        currCar.Color = currCarColor;
                    }
                }
                cars.Add(currCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

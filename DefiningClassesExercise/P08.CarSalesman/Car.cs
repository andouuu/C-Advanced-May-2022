using System;

namespace DefiningClasses
{
    public class Car
    {
        //Model: a string property
        public string Model { get; set; }
        //Engine: a property holding the engine object
        public Engine Engine = new Engine();
        //Weight: an int property, it is optional
        public int Weight = 0;
        //Color: a string property, it is optional
        public string Color = null;
        public override string ToString()
        {
            
            string displacement;
            if (Engine.Displacement==0)
                displacement = @"n/a";
            else 
                displacement = Engine.Displacement.ToString();
            string efficiency;
            if (Engine.Efficiency == null)
                efficiency = @"n/a";
            else
                efficiency = Engine.Efficiency;
            string weight;
            if (Weight == 0)
                weight = @"n/a";
            else
                weight = Weight.ToString();
            string color;
            if (Color == null)
                color = @"n/a";
            else
                color = Color;
            //"{CarModel}: 
            // { EngineModel}: 
            //  Power: { EnginePower}
            //   Displacement: { EngineDisplacement}
            //   Efficiency: { EngineEfficiency}
            // Weight: { CarWeight}
            // Color: { CarColor}
            //" 
            string car = $"{Model}:" +
                         $"\r\n  {Engine.Model}:" +
                         $"\r\n    Power: {Engine.Power}" +
                         $"\r\n    Displacement: {displacement}" +
                         $"\r\n    Efficiency: {efficiency}" +
                         $"\r\n  Weight: {weight}" +
                         $"\r\n  Color: {color}";
            return car;
        }
    }
}